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

            var group = helper.AddGroup("Infinite Demand Adjustments");
            group.AddDropdown("Residential Zones", demandRaiseOptions,
                ModOptions.DemandRaiseOptions.ResidentialZoneLevel,
                level => { ModOptions.DemandRaiseOptions.ResidentialZoneLevel = level; });
            group.AddDropdown("Commercial Zones", demandRaiseOptions, ModOptions.DemandRaiseOptions.CommercialZoneLevel,
                level => { ModOptions.DemandRaiseOptions.CommercialZoneLevel = level; });
            group.AddDropdown("Industrial Zones", demandRaiseOptions, ModOptions.DemandRaiseOptions.IndustrialZoneLevel,
                level => { ModOptions.DemandRaiseOptions.IndustrialZoneLevel = level; });
        }
    }
}
