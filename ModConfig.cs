using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx.Configuration;
using HutongGames.PlayMaker.Actions;
using UnityEngine;

namespace CitizenSleeperDiceMod
{
    public static class ModConfig
    {
        public static ConfigFile Config;

        public static ConfigEntry<bool> MaxEnergy;
        public static ConfigEntry<bool> MaxCondition;
        public static ConfigEntry<bool> MaxBits;
        public static ConfigEntry<bool> UnlimitedReroll;
        public static ConfigEntry<bool> UpgradePoints;

        public static ConfigEntry<bool> EnableDice;
        public static ConfigEntry<int> Die1;
        public static ConfigEntry<int> Die2;
        public static ConfigEntry<int> Die3;
        public static ConfigEntry<int> Die4;
        public static ConfigEntry<int> Die5;

        // RIP this section. I was going to create them dynamically, but like I want to play the game
        public static ConfigEntry<bool> CelisID;
        public static ConfigEntry<bool> ClubheadCaps;
        public static ConfigEntry<bool> EncryptedKey;
        public static ConfigEntry<bool> FengsGumBox;
        public static ConfigEntry<bool> FluxData;
        public static ConfigEntry<bool> GardenersSeed;
        public static ConfigEntry<bool> GirolleCaps;
        public static ConfigEntry<bool> GreenwayCipher;
        public static ConfigEntry<bool> GroveSpores;
        public static ConfigEntry<bool> HavenageCipher;
        public static ConfigEntry<bool> HavenageData;
        public static ConfigEntry<bool> HunterData;
        public static ConfigEntry<bool> ImprintedShipmind;
        public static ConfigEntry<bool> MatsutakeCaps;
        public static ConfigEntry<bool> RipperWorm;
        public static ConfigEntry<bool> SabinesPasskey;
        public static ConfigEntry<bool> ScrapComponents;
        public static ConfigEntry<bool> ShipmindCore;
        public static ConfigEntry<bool> ShipmindFragment;
        public static ConfigEntry<bool> SolheimCipher;
        public static ConfigEntry<bool> SolheimData;
        public static ConfigEntry<bool> Stabilizer;
        public static ConfigEntry<bool> YataganData;


        private static string PlayerModsHeader =    "-----------Player----------";
        private static string DiceModsHeader =      "------------Dice-----------";
        private static string InventoryModsHeader = "----------99 Item----------";
        public static void LoadConfig(ConfigFile config)
        {
            Config = config;

            MaxEnergy = Config.Bind(PlayerModsHeader, "Max Energy", false, new ConfigDescription("", null, new ConfigurationManagerAttributes { Order = 5 }));
            MaxCondition = Config.Bind(PlayerModsHeader, "Max Condition", false, new ConfigDescription("", null, new ConfigurationManagerAttributes { Order = 4 }));
            MaxBits = Config.Bind(PlayerModsHeader, "999 Bits", false, new ConfigDescription("", null, new ConfigurationManagerAttributes { Order = 3 }));
            UnlimitedReroll = Config.Bind(PlayerModsHeader, "Unlimited Reroll", false, new ConfigDescription("", null, new ConfigurationManagerAttributes { Order = 2 }));
            UpgradePoints = Config.Bind(PlayerModsHeader, "5 Upgrade Points", false, new ConfigDescription("", null, new ConfigurationManagerAttributes { Order = 1 }));

            EnableDice = Config.Bind(DiceModsHeader, "", false, new ConfigDescription("", null, new ConfigurationManagerAttributes { Order = 6 }));
            Die1 = Config.Bind(DiceModsHeader, "Die1", 6, new ConfigDescription("", new AcceptableValueRange<int>(0, 6), new ConfigurationManagerAttributes { Order = 5 }));
            Die2 = Config.Bind(DiceModsHeader, "Die2", 6, new ConfigDescription("", new AcceptableValueRange<int>(0, 6), new ConfigurationManagerAttributes { Order = 4 }));
            Die3 = Config.Bind(DiceModsHeader, "Die3", 6, new ConfigDescription("", new AcceptableValueRange<int>(0, 6), new ConfigurationManagerAttributes { Order = 3 }));
            Die4 = Config.Bind(DiceModsHeader, "Die4", 6, new ConfigDescription("", new AcceptableValueRange<int>(0, 6), new ConfigurationManagerAttributes { Order = 2 }));
            Die5 = Config.Bind(DiceModsHeader, "Die5", 6, new ConfigDescription("", new AcceptableValueRange<int>(0, 6), new ConfigurationManagerAttributes { Order = 1 }));

            CelisID = Config.Bind(InventoryModsHeader, "Celis ID", false, "");
            ClubheadCaps = Config.Bind(InventoryModsHeader, "Clubhead Caps", false, "");
            EncryptedKey = Config.Bind(InventoryModsHeader, "Encrypted Key", false, "");
            FengsGumBox = Config.Bind(InventoryModsHeader, "Fengs Gum Box", false, "");
            FluxData = Config.Bind(InventoryModsHeader, "Flux Data", false, "");
            GardenersSeed = Config.Bind(InventoryModsHeader, "Gardeners Seed", false, "");
            GirolleCaps = Config.Bind(InventoryModsHeader, "Girolle Caps", false, "");
            GreenwayCipher = Config.Bind(InventoryModsHeader, "Greenway Cipher", false, "");
            GroveSpores = Config.Bind(InventoryModsHeader, "Grove Spores", false, "");
            HavenageCipher = Config.Bind(InventoryModsHeader, "Havenage Cipher", false, "");
            HavenageData = Config.Bind(InventoryModsHeader, "Havenage Data", false, "");
            HunterData = Config.Bind(InventoryModsHeader, "Hunter Data", false, "");
            ImprintedShipmind = Config.Bind(InventoryModsHeader, "Imprinted Shipmind", false, "");
            MatsutakeCaps = Config.Bind(InventoryModsHeader, "Matsutake Caps", false, "");
            RipperWorm = Config.Bind(InventoryModsHeader, "Ripper Worm", false, "");
            SabinesPasskey = Config.Bind(InventoryModsHeader, "Sabines Passkey", false, "");
            ScrapComponents = Config.Bind(InventoryModsHeader, "Scrap Components", false, "");
            ShipmindCore = Config.Bind(InventoryModsHeader, "Shipmind Core", false, "");
            ShipmindFragment = Config.Bind(InventoryModsHeader, "Shipmind Fragment", false, "");
            SolheimCipher = Config.Bind(InventoryModsHeader, "Solheim Cipher", false, "");
            SolheimData = Config.Bind(InventoryModsHeader, "Solheim Data", false, "");
            Stabilizer = Config.Bind(InventoryModsHeader, "Stabilizer", false, "");
            YataganData = Config.Bind(InventoryModsHeader, "Yatagan Data", false, "");
        }
    }
}
