namespace CSLInfiniteDemandMod
{
    public static class ModOptions
    {
        public static class DemandRaiseOptions
        {
            private static readonly int[] DemandRaiseLevels = new[] {100, 50, 10, 0};

            public static int ResidentialZoneLevel = 0;
            public static int CommercialZoneLevel = 0;
            public static int IndustrialZoneLevel = 0;

            public static int ResidentialZoneRaise => DemandRaiseLevels[ResidentialZoneLevel];
            public static int CommercialZoneRaise => DemandRaiseLevels[CommercialZoneLevel];
            public static int IndustrialZoneRaise => DemandRaiseLevels[IndustrialZoneLevel];
        }
    }
}
