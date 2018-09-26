using ICities;

namespace CSLInfiniteDemandMod
{
    public class InfiniteDemandExtension : DemandExtensionBase
    {
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
