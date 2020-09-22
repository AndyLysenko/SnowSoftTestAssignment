using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SnowSite.UI.Tests.Helper;
using SnowSite.UI.Tests.Web.Type;
using System;

namespace SnowSite.UI.Tests.Web
{
    public class BrowserFactory
    {
        //private readonly BrowserType browserType;
        //private readonly TimeSpan commandTimeout = TimeSpan.FromSeconds(60);

        public BrowserFactory()
        {
            //this.browserType = browserType;
        }

        //public BrowserFactory(BrowserType browserType, TimeSpan commandTimeout)
        //{
        //    this.browserType = browserType;
        //    this.commandTimeout = commandTimeout;
        //}

        public Browser GetBrowser() => new Browser(GetDriver());

        private IWebDriver GetDriver()
        {
            int commandTimeoutSeconds = RunSettingsHelper.WebDriverSettings.GetSection("commandTimeout").Value.As<int>();
            BrowserType browserType = RunSettingsHelper.WebDriverSettings.GetSection("browser").Value.As<BrowserType>();

            switch (browserType)
            {
                case BrowserType.Chrome:
                    return new ChromeDriver(Environment.CurrentDirectory, new ChromeOptions(), TimeSpan.FromSeconds(commandTimeoutSeconds)); //TODO: check options
                case BrowserType.IE:
                case BrowserType.Firefox:
                default:
                    throw new NotImplementedException("This browser support is not implemeted yet");
            }
        }
    }
}
