using ICities;
using UnityEngine;

namespace CSLInfiniteDemandMod
{
    public class CSLInfiniteDemandMod : IUserMod
    {
        public string Name => "Infinite Demand Mod";

        public string Description => "Force infinite demand for residential, commercial and industrial zones.";

        public void OnSettingsUI(UIHelperBase helper)
        {
            var demandRaiseOptions = new[] {"High", "Medium", "Low", "None"};
            var demandRaiseLevels = new[] {100, 50, 10, 0};
            
            var group = helper.AddGroup("Infinite Demand Adjustments");
            group.AddDropdown("Residential Zones", demandRaiseOptions, 0,
                value => { ModOptions.DemandRaiseOptions.ResidentialZoneLevel = demandRaiseLevels[value]; });
            group.AddDropdown("Commercial Zones", demandRaiseOptions, 0,
                value => { ModOptions.DemandRaiseOptions.CommercialZoneLevel = demandRaiseLevels[value]; });
            group.AddDropdown("Industrial Zones", demandRaiseOptions, 0,
                value => { ModOptions.DemandRaiseOptions.IndustrialZoneLevel = demandRaiseLevels[value]; });
        }
    }
}
