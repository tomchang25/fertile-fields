using System;
using System.Collections.Generic;
using RimWorld;
using Verse;
using Verse.AI;

namespace RFF_Code
{
    public class WorkGiver_Excavate : WorkGiver_Scanner
    {
        public override PathEndMode PathEndMode
        {
            get { return PathEndMode.InteractionCell; }
        }

        public override IEnumerable<Thing> PotentialWorkThingsGlobal(Pawn pawn)
        {
            if (pawn.Map == null) yield break;
            foreach (ThingDef thingDef in def.fixedBillGiverDefs)
            {
                foreach (Building building in pawn.Map.listerBuildings.AllBuildingsColonistOfDef(thingDef))
                {
                    yield return building;
                }
            }
        }

        public override Job JobOnThing(Pawn pawn, Thing t, bool forced = false)
        {
            IBillGiver billGiver = t as IBillGiver;
            if (billGiver == null) return null;
            CompPowerTrader power = t.TryGetComp<CompPowerTrader>();
            if (power != null && !power.PowerOn) return null;
            if (!pawn.CanReserve(t)) return null;
            foreach (Bill bill in billGiver.BillStack)
            {
                if (bill.ShouldDoNow())
                {
                    Job job = JobMaker.MakeJob(FFDefOf.RFF_Excavate, t);
                    job.bill = bill;
                    return job;
                }
            }
            return null;
        }
    }

    public class JobDriver_Excavate : JobDriver
    {
        private float workDone;

        public override bool TryMakePreToilReservations(bool errorOnFailed)
        {
            return pawn.Reserve(job.targetA, job, 1, -1, null, errorOnFailed);
        }

        protected override IEnumerable<Toil> MakeNewToils()
        {
            yield return Toils_Goto.GotoThing(TargetIndex.A, PathEndMode.InteractionCell)
                .FailOnDespawnedNullOrForbidden(TargetIndex.A);

            Toil work = new Toil();
            work.initAction = delegate {
                workDone = 0f;
            };
            work.tickAction = delegate {
                Pawn actor = work.actor;
                actor.skills?.Learn(SkillDefOf.Mining, 0.06f, false);
                Thing building = job.GetTarget(TargetIndex.A).Thing;
                float speed = actor.GetStatValue(StatDefOf.MiningSpeed) * building.GetStatValue(StatDefOf.WorkTableWorkSpeedFactor);
                workDone += speed;
                if (workDone >= job.bill.recipe.workAmount)
                {
                    foreach (ThingDefCountClass product in job.bill.recipe.products)
                    {
                        Thing thing = ThingMaker.MakeThing(product.thingDef);
                        thing.stackCount = product.count;
                        GenPlace.TryPlaceThing(thing, building.Position, building.Map, ThingPlaceMode.Near);
                    }
                    job.bill.Notify_IterationCompleted(actor, null);
                    ReadyForNextToil();
                }
            };
            work.WithEffect(() => job.bill.recipe.effectWorking, TargetIndex.A);
            work.PlaySustainerOrSound(() => job.bill.recipe.soundWorking);
            work.FailOnDespawnedNullOrForbidden(TargetIndex.A);
            work.FailOnBurningImmobile(TargetIndex.A);
            work.FailOn((Func<bool>)delegate {
                CompPowerTrader power = job.GetTarget(TargetIndex.A).Thing.TryGetComp<CompPowerTrader>();
                return power != null && !power.PowerOn;
            });
            work.defaultCompleteMode = ToilCompleteMode.Never;
            work.activeSkill = () => SkillDefOf.Mining;
            yield return work;
        }
    }
}
