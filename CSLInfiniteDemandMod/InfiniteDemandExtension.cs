using ICities;

namespace CSLInfiniteDemandMod
{
    public class InfiniteDemandExtension : DemandExtensionBase
    {
        private const int DemandValue = 100;

        public override int OnCalculateResidentialDemand(int originalDemand)
        {
            return DemandValue;
        }

        public override int OnCalculateCommercialDemand(int originalDemand)
        {
            return DemandValue;
        }

        public override int OnCalculateWorkplaceDemand(int originalDemand)
        {
            return DemandValue;
        }
    }
}
