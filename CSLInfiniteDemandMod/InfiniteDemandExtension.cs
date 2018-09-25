using ICities;

namespace CSLInfiniteDemandMod
{
    public class InfiniteDemandExtension : DemandExtensionBase
    {
        private const int DemandValue = 100;

        public override int OnCalculateResidentialDemand(int originalDemand)
        {
            return ModOptions.DemandRaiseOptions.ResidentialZoneLevel;
        }

        public override int OnCalculateCommercialDemand(int originalDemand)
        {
            return ModOptions.DemandRaiseOptions.CommercialZoneLevel;
        }

        public override int OnCalculateWorkplaceDemand(int originalDemand)
        {
            return ModOptions.DemandRaiseOptions.IndustrialZoneLevel;
        }
    }
}
