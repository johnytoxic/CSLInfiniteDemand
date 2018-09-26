using System.Collections.Generic;
using System.Linq;
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
            group.AddDropdown("Residential Zones", DemandSettings.DemandRaiseOptionNames,
                DemandSettings.ResidentialRaiseOption, option => DemandSettings.ResidentialRaiseOption = option);
            group.AddDropdown("Commercial Zones", DemandSettings.DemandRaiseOptionNames,
                DemandSettings.CommercialRaiseOption, option => DemandSettings.CommercialRaiseOption = option);
            group.AddDropdown("Industrial Zones", DemandSettings.DemandRaiseOptionNames,
                DemandSettings.IndustrialRaiseOption, option => DemandSettings.IndustrialRaiseOption = option);
        }
    }
}
