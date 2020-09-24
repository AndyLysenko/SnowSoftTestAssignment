using Microsoft.Extensions.Configuration;
using System.IO;

namespace SnowSite.UI.Tests.Helper
{
    public class RunSettingsHelper
    {
        private static readonly IConfigurationRoot RunSettings;

        static RunSettingsHelper()
        {
            RunSettings = ReadConfiguration();
        }

        public static IConfigurationSection WebDriverSettings => RunSettings.GetSection("webdriver");
        public static IConfigurationSection RunEnvironment => RunSettings.GetSection("environment");
        public static IConfigurationSection UiSettings => RunSettings.GetSection("ui");

        private static IConfigurationRoot ReadConfiguration()
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("runsettingsGlobal.json", optional: false, reloadOnChange: true);
            return configurationBuilder.Build();
        }
    }
}
