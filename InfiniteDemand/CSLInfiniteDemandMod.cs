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
            UIHelperBase group = helper.AddGroup("Infinite Demand");
            group.AddCheckbox("Enable infinite demand", Settings.Enabled.value, (val) => Settings.Enabled.value = val);
        }
    }
}
