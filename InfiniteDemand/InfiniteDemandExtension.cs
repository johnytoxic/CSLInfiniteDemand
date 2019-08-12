using ICities;

namespace CSLInfiniteDemandMod
{
    public class InfiniteDemandExtension : DemandExtensionBase
    {
        private const int DemandRaiseLevel = 100;

        public override int OnUpdateDemand(int lastDemand, int nextDemand, int targetDemand)
        {
            return DemandRaiseLevel;
        }
    }
}
