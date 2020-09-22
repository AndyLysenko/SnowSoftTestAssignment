using SnowSite.UI.Tests.Web;

namespace SnowSite.UI.Tests.Context
{
    public static class WebContext
    {
        static WebContext() { }

        public static Browser Browser { get; private set; }
        //public static IWebDriver WebDriver { get; private set; }

        public static void Initialize()
        {
            Browser = new BrowserFactory().GetBrowser();
        }

        public static void Dispose()
        {
            Browser?.Dispose();
        }
    }
}
