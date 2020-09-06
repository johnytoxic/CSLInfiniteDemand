using ICities;

namespace CSLInfiniteDemandMod
{
    public class InfiniteDemandExtension : DemandExtensionBase
    {
        private interface IDemandHandler
        {
            int OnUpdateDemand(int lastDemand, int nextDemand, int targetDemand);
        }

        private class InfiniteDemand : IDemandHandler
        {
            public int OnUpdateDemand(int lastDemand, int nextDemand, int targetDemand)
            {
                return 100;
            }
        }

        private class PassThruDemand : DemandExtensionBase, IDemandHandler
        {
        }

        private IDemandHandler DemandHandler;
        private void EnableInfiniteDemand(bool enable)
        {
            DemandHandler = enable ? new InfiniteDemand() : (IDemandHandler) new PassThruDemand();
        }
        public override void OnCreated(IDemand demand)
        {
            EnableInfiniteDemand(Settings.Enabled.value);
            Settings.Enabled.handlers += (value) => EnableInfiniteDemand(value);
        }

        public override int OnUpdateDemand(int lastDemand, int nextDemand, int targetDemand)
        {
            return DemandHandler.OnUpdateDemand(lastDemand, nextDemand, targetDemand);
        }
    }
}
