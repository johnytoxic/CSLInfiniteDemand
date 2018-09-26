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
            var group = helper.AddGroup("Infinite Demand Adjustments");
            group.AddDropdown("Residential Zones", ModOptions.DemandRaiseOptions.DemandRaiseOptionNames,
                ModOptions.DemandRaiseOptions.ResidentialZoneLevel,
                level => { ModOptions.DemandRaiseOptions.ResidentialZoneLevel = level; });
            group.AddDropdown("Commercial Zones", ModOptions.DemandRaiseOptions.DemandRaiseOptionNames,
                ModOptions.DemandRaiseOptions.CommercialZoneLevel,
                level => { ModOptions.DemandRaiseOptions.CommercialZoneLevel = level; });
            group.AddDropdown("Industrial Zones", ModOptions.DemandRaiseOptions.DemandRaiseOptionNames,
                ModOptions.DemandRaiseOptions.IndustrialZoneLevel,
                level => { ModOptions.DemandRaiseOptions.IndustrialZoneLevel = level; });
        }
    }
}
