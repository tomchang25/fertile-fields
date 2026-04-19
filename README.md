# Fertile Fields (Continued)

Unofficial continuation of the Fertile Fields mod. All credit to the original authors for their work.

- **Rainbeau Flambe (dburgdorf)** — Original author. Created the mod from Alpha 16 (Jan 2017) through RimWorld 1.0.
- **Jamaican Castle** — Took over maintenance from 1.1 (Mar 2020), added multi-terraforming tools, plant scrap rebalancing, and growing zone options. Last updated for 1.4 (Oct 2022). ([Steam page](https://steamcommunity.com/sharedfiles/filedetails/?id=2012735237))
- **Greysuki** — Current maintainer. Unofficial update for 1.5/1.6 (Jul 2025–present). ([Steam page](https://steamcommunity.com/sharedfiles/filedetails/?id=3225843229))

---

## Overview

Fertile Fields allows you to transform and improve your colony's terrain, harvest raw materials from the land, and use them to enhance your environment.

---

## Terraforming

The Terraforming tab of the architect menu allows you to modify terrain to suit the needs of your colony. Transforming tiles to less fertile or useful terrain will generally yield resources such as sand, dirt, clay, or rock. Transforming tiles to more fertile terrain requires resources.

Multi-terraformers, will transform any terrain underneath them into the selected terrain. This may take multiple steps; if so, extra steps are built automatically after the first one is completed.

If you right-click on a multi-terraformer, you can select a single terraformer that will transform only one specific type of terrain into the selected terrain. More information about each transformation can be found in its single terraformer's description.

The Terraforming technology unlocks the ability to perform more sweeping modifications of terrain: removing shallow water and marsh, transforming deep water into shallow water (or vice versa), and placing or breaking up solid stone terrain.

Terrains that share an affordance type with a basic terrain (such as soft sand for sand) can be transformed directly into that type. This mostly affects mod-added terrain.

---

## Farming

The Farming tab of the architect menu allows you to enhance the fertility of your soil and the usefulness of your farms. Compost bins and barrels allow you to transform raw compost, created at the butcher's table, into fertilizer that can transform regular soil into rich soil.

The Farming technology expands your options by allowing you to place dirt on smooth stone or ice terrain to form topsoil, which can be fertilized. Rich soil, meanwhile, can be tilled for an even greater improvement in productivity.

Fertile soil used in a growing zone will eventually degrade into less fertile soil. You can use excess plant material to mitigate this, or harvest these plant scraps to make fertilizer, as animal feed, or to fuel generators.

Growing zones have two toggleable options: return to soil and automatically redesignate. The first option causes plants harvested there to not drop plant scraps, but to deplete soil less often. (This is generally less efficient than harvesting the scraps and refertilizing, but saves a lot of labor and storage space.) The second option triggers automatic rebuilding of any soil that depletes.

---

## Construction

Clay can be fired at a smithy to create bricks for walls, floors, and other constructions. In addition to being dug up, clay can be ground from dirt or sand (and sand from rocks) at a stonecutter's table.

The rock mill is a new production bench that acts as an electrically powered stonecutter's table.

---

## Plant Scraps & Power

Plants produce plant scraps on harvest. Yields vary by plant type; plants harvested in the wild or from hydroponics have 50% lower plant scrap yields. A fueled generator consumes 75 plant scraps per day for 1000W of power. All terraforming-related resources (including plant scraps) stack to 200. Fertilizer is less valuable when sold to caravans.

---

## Compatibility

- Terrains from **Dub's Hygiene**, **CuproPanda's Quarry**, **Crashlanding**, **Nature's Pretty Sweet**, **Biomes!**, and **Tiberium Rim** can be modified by Fertile Fields terrain transformations, where appropriate. (Note that this does *not* include Tiberium terrain in Tiberium Rim, which must be decrystallized first.)
- Compatible with **Seeds Please!**.
- Glass production from **Glass+Lights** and **Dub's Skylights** will use sand from Fertile Fields.
- **Vanilla Furniture Expanded – Production** will remove the rock mill from the build menu, since it's redundant with that mod's electrical stonecutting table. Existing rock mills will still function.
- Compatible with **Vegetable Garden**, but will overwrite certain VGP Garden Tools that overlap with Fertile Fields tools. In addition, many VGP tools are located in the Farming tab.

---

## Known Issues

- **Odyssey DLC**: Odyssey terrain is not currently supported by Fertile Fields terraforming.
- **Alpha Biomes**: Alpha Biomes terrain is not natively supported. A third-party patch is available: [Dragon's Fertile Fields Alpha Biomes Patches](https://steamcommunity.com/sharedfiles/filedetails/?id=3423634406). (Not tested on my end.)
- **ReGrowth: Core**: ReGrowth's custom soil may cause terraforming to fail, especially in temperate biomes. A third-party patch is available: [ReGrowth: Core - Fertile Fields patch](https://steamcommunity.com/sharedfiles/filedetails/?id=2473687538). (Not tested on my end.)
- **Compost bin progress bar**: The progress bar does not render on the compost bin graphic. Progress percentage is still visible in the info panel when selected.
- **Compost bin power**: The compost bin does not actually require power to function, despite what the UI may suggest.

---

## Credits

- Fertile Fields 1.0 and earlier by **Rainbeau Flambe (dburgdorf)**.
- Updated to 1.1–1.4 by **Jamaican Castle**.
- German translation by **Ryder32x** and **Erdnussbrot**.
- Korean translation by **NEPH**.
- French translation by **Redstylt**.
- Russian translation by **fox_kirya**.
- Compost bin C# code derived from **Dismarzero**'s "Vegetable Garden."
- Code contributions by **NotFood**.
- Scrap-fueled generator XML and graphic by **Pelador**.
- Hygiene production compatibility patches by **dninemfive**.
- Uses the **Harmony** patch library by **Pardeike**.

---

## License

If you're a modpack maker and want to include "Fertile Fields" in your pack, or if you're a modder and want to use "Fertile Fields" as the basis of a derivative mod, please feel free to do so. I ask only that you let me know about it.
