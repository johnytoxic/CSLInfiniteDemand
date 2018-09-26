using ICities;

namespace CSLInfiniteDemandMod
{
    public class InfiniteDemandExtension : DemandExtensionBase
    {
        public override int OnCalculateResidentialDemand(int originalDemand)
        {
            return DemandSettings.ResidentialZoneRaise;
        }

        public override int OnCalculateCommercialDemand(int originalDemand)
        {
            return DemandSettings.CommercialZoneRaise;
        }

        public override int OnCalculateWorkplaceDemand(int originalDemand)
        {
            return DemandSettings.IndustrialZoneRaise;
        }
    }
}
