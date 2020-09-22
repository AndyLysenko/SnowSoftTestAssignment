using HtmlElements.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SnowSite.UI.Tests.Element;
using SnowSite.UI.Tests.Helper;
using SnowSite.UI.Tests.Web;

namespace SnowSite.UI.Tests.Page
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//ul[@data-region='main_menu']/li/a[contains(text(), 'Success')]")]
        private readonly HtmlLink successLink;

        public HomePage() : base()
        {
            Name = "Home Page";
            Browser.GoTo(RunSettingsHelper.RunEnvironment.GetSection("homepage").Value);
        }

        public GlobalCommunityPage OpenGlobalCommunityPage()
        {
            successLink.MouseHover_SubMenuClick(By.XPath("//li/a[contains(text(), 'Snow Globe Community')]"));
            return Activator.Get<GlobalCommunityPage>();
        }
    }
}
