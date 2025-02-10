using HarmonyLib;
using PixelCrushers.DialogueSystem.PlayMaker;

// patching set variable causes the values to be saved.

namespace CitizenSleeperDiceMod
{
    //[HarmonyPatch(typeof(SetVariable), "OnEnter")]
    //class PlayMaker_SetVariable_OnEnter_Patch
    //{
    //    [HarmonyPrefix]
    //    public static bool Prefix(SetVariable __instance)
    //    {
    //        if (__instance.variableName == null || string.IsNullOrEmpty(__instance.variableName.Value))
    //        {
    //            // Exit early and run the original code if things are goofy
    //            return true;
    //        }
    //        if (__instance.variableName.Value.Equals("DieCondition"))
    //        {
    //            // lazy way to make the die assignments easier
    //            return true;
    //        }

    //        if (__instance.variableName.Value.StartsWith("Die") && ModConfig.EnableDice.Value)
    //        {
    //            if (__instance.variableName.Value.Equals("Die1"))
    //                __instance.floatValue.Value = ModConfig.Die1.Value;
    //            else if (__instance.variableName.Value.Equals("Die2"))
    //                __instance.floatValue.Value = ModConfig.Die2.Value;
    //            else if (__instance.variableName.Value.Equals("Die3"))
    //                __instance.floatValue.Value = ModConfig.Die3.Value;
    //            else if (__instance.variableName.Value.Equals("Die4"))
    //                __instance.floatValue.Value = ModConfig.Die4.Value;
    //            else if (__instance.variableName.Value.Equals("Die5"))
    //                __instance.floatValue.Value = ModConfig.Die5.Value;
    //        }
    //        if (__instance.variableName.Value.Equals("Player_Energy") && ModConfig.MaxEnergy.Value)
    //        {
    //            __instance.floatValue.Value = 100;
    //        }
    //        if (__instance.variableName.Value.Equals("Player_Condition") && ModConfig.MaxCondition.Value)
    //        {
    //            __instance.floatValue.Value = 100;
    //        }
    //        if (__instance.variableName.Value.Equals("Player_Bits") && ModConfig.MaxBits.Value)
    //        {
    //            __instance.floatValue.Value = 999;
    //        }
    //        if (__instance.variableName.Value.Equals("REROLL") && ModConfig.UnlimitedReroll.Value)
    //        {
    //            __instance.floatValue.Value = 0;
    //        }
    //        if (__instance.variableName.Value.Equals("Player_UpgradePoints") && ModConfig.UpgradePoints.Value)
    //        {
    //            __instance.floatValue.Value = 5;
    //        }
    //        // Always run the actual set function
    //        return true;
    //    }
    //}
}
