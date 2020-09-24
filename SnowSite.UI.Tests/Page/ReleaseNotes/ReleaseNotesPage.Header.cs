#pragma warning disable IDE1006
using HtmlElements.Elements;
using OpenQA.Selenium;
using SnowSite.UI.Tests.Page.Base;

namespace SnowSite.UI.Tests.Page.ReleaseNotes
{
    public class ReleaseNotesPageHeader : ElementsContainer
    {
        //elements
        private HtmlLink supportLink => FindElementAs<HtmlLink>(By.XPath("//a[contains(., 'Support')]"));

        public ReleaseNotesPageHeader(IWebElement wrappedElement) : base(wrappedElement) { LogName = "Release Notes Page Header"; }

        //page actions
        public void OpenSupport() => supportLink.Click();   //support page not defined yet. out of assignment scope. just an example.
    }
}