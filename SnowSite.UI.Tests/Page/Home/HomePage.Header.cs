#pragma warning disable IDE1006
using HtmlElements.Elements;
using HtmlElements.Extensions;
using OpenQA.Selenium;
using SnowSite.UI.Tests.Page.Base;
using SnowSite.UI.Tests.Page.GlobalCommunity;
using SnowSite.UI.Tests.Web.Extension.Element;

namespace SnowSite.UI.Tests.Page.Home
{
    public class HomePageHeader : ElementsContainer
    {
        //elements
        private HtmlLink successLink => FindElementAs<HtmlLink>(By.XPath("//a[contains(text(), 'Success')]"));

        public HomePageHeader(IWebElement wrappedElement) : base(wrappedElement) { LogName = "Home Page Header"; }

        //page actions
        public GlobalCommunityPage OpenCommunity()
            => successLink.WaitForVisible().OpenSubMenuItemBy<GlobalCommunityPage>(By.XPath($"//*[contains(text(), 'Snow Globe Community')]"));
    }
}