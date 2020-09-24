using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SnowSite.UI.Tests.Context;
using SnowSite.UI.Tests.Helper;
using SnowSite.UI.Tests.Web.Type;
using System;

namespace SnowSite.UI.Tests.Web
{
    public class BrowserFactory
    {
        private readonly BrowserType browserType;

        public BrowserFactory(BrowserType? browserType = null)
        {
            this.browserType = browserType ?? RunSettingsHelper.WebDriverSettings.GetSection("browser").Value.As<BrowserType>();
        }

        public Browser GetBrowser() => new Browser(GetDriver());

        private IWebDriver GetDriver()
        {
            IWebDriver driver;
            int commandTimeoutSeconds = RunSettingsHelper.WebDriverSettings.GetSection("commandTimeout").Value.As<int>();
            int searchTimeout = RunSettingsHelper.WebDriverSettings.GetSection("searchTimeout").Value.As<int>();
            int pageLoadTimeout = RunSettingsHelper.WebDriverSettings.GetSection("pageLoadTimeout").Value.As<int>();

            TestContext.Instance.Logger.WriteLine($"Starting {browserType}").BreakLine();

            switch (browserType)
            {
                case BrowserType.Chrome:
                    driver = new ChromeDriver(Environment.CurrentDirectory, GetChromeOptions(), TimeSpan.FromSeconds(commandTimeoutSeconds));
                    break;
                case BrowserType.Firefox:
                    driver = new FirefoxDriver(Environment.CurrentDirectory, GetFirefoxOptions(), TimeSpan.FromSeconds(commandTimeoutSeconds));
                    break;
                case BrowserType.IE:
                case BrowserType.Edge:
                default:
                    throw new NotImplementedException("This browser is not supported yet");
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(searchTimeout);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadTimeout);
            return driver;
        }

        //TODO: make options factory
        #region driver options
        private ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("intl.accept_languages", "en");
            options.AddUserProfilePreference("disable-popup-blocking", "true");
            options.AddArgument("start-maximized");
            options.AddArgument("version");
            options.Proxy = null;
            return options;
        }

        private FirefoxOptions GetFirefoxOptions() => new FirefoxOptions();
        #endregion
    }
}
