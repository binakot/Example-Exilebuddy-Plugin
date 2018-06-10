using Loki;
using Loki.Common;

namespace ExampleExilebuddyPlugin
{
    class ExamplePluginSettings : JsonSettings
    {
        public ExamplePluginSettings() 
            : base(GetSettingsFilePath(Configuration.Instance.Name, string.Format("{0}.json", "ExamplePlugin")))
        {
        }
    }
}
