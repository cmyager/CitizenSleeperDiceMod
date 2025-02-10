using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using PixelCrushers.DialogueSystem.PlayMaker;
using Rewired.Integration.PlayMaker;

namespace CitizenSleeperDiceMod
{
    [HarmonyPatch(typeof(GetVariable), "GetAndStore")]
    class PlayMaker_GetVariable_GetAndStore_Patch
    {
        [HarmonyPrefix]
        private static bool Prefix(GetVariable __instance)
        {
            if (__instance.variableName == null || string.IsNullOrEmpty(__instance.variableName.Value))
            {
                // Exit early and run the original code if things are goofy
                return true;
            }
            if (__instance.variableName.Value.Equals("DieCondition"))
            {
                // lazy way to make the die assignments easier
                return true;
            }

            bool run_original = false;

            // Player
            if (__instance.variableName.Value.Equals("Player_Energy") && ModConfig.MaxEnergy.Value)
                __instance.storeFloatResult.Value = 100;
            else if (__instance.variableName.Value.Equals("Player_Condition") && ModConfig.MaxCondition.Value)
                __instance.storeFloatResult.Value = 100;
            else if (__instance.variableName.Value.Equals("Player_Bits") && ModConfig.MaxBits.Value)
                __instance.storeFloatResult.Value = 999;
            else if (__instance.variableName.Value.Equals("REROLL") && ModConfig.UnlimitedReroll.Value)
                __instance.storeFloatResult.Value = 0;
            else if (__instance.variableName.Value.Equals("Player_UpgradePoints") && ModConfig.UpgradePoints.Value)
                __instance.storeFloatResult.Value = 5;

            // Dice
            else if (__instance.variableName.Value.StartsWith("Die") && ModConfig.EnableDice.Value)
            {
                if (__instance.variableName.Value.Equals("Die1"))
                    __instance.storeFloatResult.Value = ModConfig.Die1.Value;
                else if (__instance.variableName.Value.Equals("Die2"))
                    __instance.storeFloatResult.Value = ModConfig.Die2.Value;
                else if (__instance.variableName.Value.Equals("Die3"))
                    __instance.storeFloatResult.Value = ModConfig.Die3.Value;
                else if (__instance.variableName.Value.Equals("Die4"))
                    __instance.storeFloatResult.Value = ModConfig.Die4.Value;
                else if (__instance.variableName.Value.Equals("Die5"))
                    __instance.storeFloatResult.Value = ModConfig.Die5.Value;
            }

            // 99 Item
            // Note: Could be better. but I just want to play the game.
            else if (__instance.variableName.Value.StartsWith("INV_"))
            {
                if ((__instance.variableName.Value.Equals("INV_CelisID") && ModConfig.CelisID.Value)
                || (__instance.variableName.Value.Equals("INV_ClubheadCaps") && ModConfig.ClubheadCaps.Value)
                || (__instance.variableName.Value.Equals("INV_EncryptedKey") && ModConfig.EncryptedKey.Value)
                || (__instance.variableName.Value.Equals("INV_FengsGumBox") && ModConfig.FengsGumBox.Value)
                || (__instance.variableName.Value.Equals("INV_FluxData") && ModConfig.FluxData.Value)
                || (__instance.variableName.Value.Equals("INV_GardenersSeed") && ModConfig.GardenersSeed.Value)
                || (__instance.variableName.Value.Equals("INV_GirolleCaps") && ModConfig.GirolleCaps.Value)
                || (__instance.variableName.Value.Equals("INV_GreenwayCipher") && ModConfig.GreenwayCipher.Value)
                || (__instance.variableName.Value.Equals("INV_GroveSpores") && ModConfig.GroveSpores.Value)
                || (__instance.variableName.Value.Equals("INV_HavenageCipher") && ModConfig.HavenageCipher.Value)
                || (__instance.variableName.Value.Equals("INV_HavenageData") && ModConfig.HavenageData.Value)
                || (__instance.variableName.Value.Equals("INV_HunterData") && ModConfig.HunterData.Value)
                || (__instance.variableName.Value.Equals("INV_ImprintedShipmind") && ModConfig.ImprintedShipmind.Value)
                || (__instance.variableName.Value.Equals("INV_MatsutakeCaps") && ModConfig.MatsutakeCaps.Value)
                || (__instance.variableName.Value.Equals("INV_RipperWorm") && ModConfig.RipperWorm.Value)
                || (__instance.variableName.Value.Equals("INV_SabinesPasskey") && ModConfig.SabinesPasskey.Value)
                || (__instance.variableName.Value.Equals("INV_ScrapComponents") && ModConfig.ScrapComponents.Value)
                || (__instance.variableName.Value.Equals("INV_ShipmindCore") && ModConfig.ShipmindCore.Value)
                || (__instance.variableName.Value.Equals("INV_ShipmindFragment") && ModConfig.ShipmindFragment.Value)
                || (__instance.variableName.Value.Equals("INV_SolheimCipher") && ModConfig.SolheimCipher.Value)
                || (__instance.variableName.Value.Equals("INV_SolheimData") && ModConfig.SolheimData.Value)
                || (__instance.variableName.Value.Equals("INV_Stabilizer") && ModConfig.Stabilizer.Value)
                || (__instance.variableName.Value.Equals("INV_YataganData") && ModConfig.YataganData.Value))
                {
                    __instance.storeFloatResult.Value = 99;
                }
                else
                {
                    // I think I got them all, but just to be safe
                    run_original = true;
                }
            }
            else
            {
                run_original = true;
            }
            return run_original;
        }
    }
}
