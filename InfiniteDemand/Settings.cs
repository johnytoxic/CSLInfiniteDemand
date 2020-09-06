using ColossalFramework;

namespace CSLInfiniteDemandMod
{
    internal class Settings
    {
        // Extracted from Settings class
        private static readonly string gameSettingsFile = "gameSettings";

        public static SubscribableSavedBool Enabled = new SubscribableSavedBool("InfiniteDemandMod.Enable", gameSettingsFile, true);
    }
}
