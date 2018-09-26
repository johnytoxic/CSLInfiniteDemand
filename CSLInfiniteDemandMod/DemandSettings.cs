using UnityEngine;

namespace CSLInfiniteDemandMod
{
    internal static class DemandSettings
    {
        public static readonly string[] DemandRaiseOptionNames = new[] {"None", "Low", "Medium", "High"};
        private static readonly int[] DemandRaiseLevels = new[] {0, 10, 50, 100};
        private static readonly int DemandDefaultRaiseOption = 3;

        private static int? _residentialRaiseOption;

        public static int ResidentialRaiseOption
        {
            get
            {
                if (!_residentialRaiseOption.HasValue)
                {
                    _residentialRaiseOption =
                        PlayerPrefs.GetInt("CSLInfiniteDemandMod_DemandSettings_ResidentialRaiseOption",
                            DemandDefaultRaiseOption);
                }

                return _residentialRaiseOption.Value;
            }

            set
            {
                if (_residentialRaiseOption == value)
                {
                    return;
                }

                _residentialRaiseOption = value;
                PlayerPrefs.SetInt("CSLInfiniteDemandMod_DemandSettings_ResidentialRaiseOption", value);
            }
        }

        private static int? _commercialRaiseOption;

        public static int CommercialRaiseOption
        {
            get
            {
                if (!_commercialRaiseOption.HasValue)
                {
                    _commercialRaiseOption =
                        PlayerPrefs.GetInt("CSLInfiniteDemandMod_DemandSettings_CommercialRaiseOption",
                            DemandDefaultRaiseOption);
                }

                return _commercialRaiseOption.Value;
            }

            set
            {
                if (_commercialRaiseOption == value)
                {
                    return;
                }

                _commercialRaiseOption = value;
                PlayerPrefs.SetInt("CSLInfiniteDemandMod_DemandSettings_CommercialRaiseOption", value);
            }
        }

        private static int? _industrialRaiseOption;

        public static int IndustrialRaiseOption
        {
            get
            {
                if (!_industrialRaiseOption.HasValue)
                {
                    _industrialRaiseOption =
                        PlayerPrefs.GetInt("CSLInfiniteDemandMod_DemandSettings_IndustrialRaiseOption",
                            DemandDefaultRaiseOption);
                }

                return _industrialRaiseOption.Value;
            }

            set
            {
                if (_industrialRaiseOption == value)
                {
                    return;
                }

                _industrialRaiseOption = value;
                PlayerPrefs.SetInt("CSLInfiniteDemandMod_DemandSettings_IndustrialRaiseOption", value);
            }
        }

        public static int ResidentialZoneRaise => DemandRaiseLevels[ResidentialRaiseOption];
        public static int CommercialZoneRaise => DemandRaiseLevels[CommercialRaiseOption];
        public static int IndustrialZoneRaise => DemandRaiseLevels[IndustrialRaiseOption];
    }
}
