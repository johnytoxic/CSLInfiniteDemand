using ICities;

namespace CSLInfiniteDemandMod
{
    public class InfiniteDemandExtension : DemandExtensionBase
    {
        private const int DemandValue = 100;

        public override int OnCalculateResidentialDemand(int originalDemand)
        {
            return ModOptions.DemandRaiseOptions.ResidentialZoneRaise;
        }

        public override int OnCalculateCommercialDemand(int originalDemand)
        {
            return ModOptions.DemandRaiseOptions.CommercialZoneRaise;
        }

        public override int OnCalculateWorkplaceDemand(int originalDemand)
        {
            return ModOptions.DemandRaiseOptions.IndustrialZoneRaise;
        }
    }
}
