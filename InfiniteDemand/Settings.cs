using ColossalFramework;

namespace CSLInfiniteDemandMod
{
    internal class Settings
    {
        // Extracted from Settings class
        private static readonly string gameSettingsFile = "gameSettings";

        public static SavedBool Enabled = new SavedBool("InfiniteDemandMod.Enable", gameSettingsFile, true);
    }
}
