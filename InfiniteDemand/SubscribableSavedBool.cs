using ColossalFramework;

namespace CSLInfiniteDemandMod
{
    class SubscribableSavedBool
    {
        public delegate void OnUpdateValue(bool value);

        private SavedBool source;
        public OnUpdateValue handlers;

        public SubscribableSavedBool(string name, string fileName, bool def)
        {
            source = new SavedBool(name, fileName, def);
        }

        public bool value
        {
            get
            {
                return source.value;
            }

            set
            {
                source.value = value;
                handlers.Invoke(value);
            }
        }
    }
}
