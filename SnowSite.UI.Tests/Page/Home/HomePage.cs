#pragma warning disable IDE1006
using OpenQA.Selenium;
using SnowSite.UI.Tests.Helper;
using SnowSite.UI.Tests.Page.GlobalCommunity;
using SnowSite.UI.Tests.Web;

namespace SnowSite.UI.Tests.Page.Home
{
    public class HomePage : BasePage
    {
        //page components
        private HomePageHeader header => new HomePageHeader(FindElement(By.Id("header")));

        public HomePage() : base()
        {
            LogName = "Home Page";
            Browser.GoTo(RunSettingsHelper.RunEnvironment.GetSection("homepageUrl").Value);
            Browser.TakeScreenshot();
        }

        //page actions
        public GlobalCommunityPage OpenGlobalCommunityPage() => header.OpenCommunity();
    }
}