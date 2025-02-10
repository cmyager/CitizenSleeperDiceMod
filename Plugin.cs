using BepInEx;
using BepInEx.Logging;
using System;
using System.Reflection;
using HarmonyLib;

// TODO: cleanup name stuff.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace CitizenSleeperDiceMod
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        internal static new ManualLogSource Logger;
        private void Awake()
        {
            // Plugin startup logic
            Logger = base.Logger;
            Logger.LogInfo("Loaded");

            // ConfigFile from base class
            Config.SaveOnConfigSet = true;

            ModConfig.LoadConfig(Config);
            Logger.LogInfo("Config loaded");

            var harmony = new Harmony("com.cmyager.plugin.CS.DiceMod");
            try
            {
                harmony.PatchAll();
                Logger.LogInfo("Patched");
            }
            catch (Exception ex)
            {
                Logger.LogInfo($"EXCEPTION: {ex}");
            }
        }
        void OnDestroy()
        {
            Harmony.UnpatchAll();
        }
    }
}
