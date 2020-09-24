#pragma warning disable IDE1006
using HtmlElements.Elements;
using OpenQA.Selenium;
using SnowSite.UI.Tests.Page.Base;

namespace SnowSite.UI.Tests.Page.GlobalCommunity
{
    public class GlobalCommunityPageHeader : ElementsContainer
    {
        //page components
        private HtmlLink supportLink => FindElementAs<HtmlLink>(By.XPath("//a[., 'Support')]"));

        public GlobalCommunityPageHeader(IWebElement wrappedElement) : base(wrappedElement) { LogName = "Global Community Page Header"; }

        //page actions
        public void OpenSupport() => supportLink.Click();   //support page not defined yet. out of assignment scope. just an example.
    }
}