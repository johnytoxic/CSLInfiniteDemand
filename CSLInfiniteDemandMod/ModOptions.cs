namespace CSLInfiniteDemandMod
{
    internal static class ModOptions
    {
        internal static class DemandRaiseOptions
        {
            public static readonly string[] DemandRaiseOptionNames = new[] {"None", "Low", "Medium", "High"};
            private static readonly int[] DemandRaiseLevels = new[] {0, 10, 50, 100};
            private static readonly int DemandLevelDefault = 3;

            public static int ResidentialZoneLevel = DemandLevelDefault;
            public static int CommercialZoneLevel = DemandLevelDefault;
            public static int IndustrialZoneLevel = DemandLevelDefault;

            public static int ResidentialZoneRaise => DemandRaiseLevels[ResidentialZoneLevel];
            public static int CommercialZoneRaise => DemandRaiseLevels[CommercialZoneLevel];
            public static int IndustrialZoneRaise => DemandRaiseLevels[IndustrialZoneLevel];
        }
    }
}
