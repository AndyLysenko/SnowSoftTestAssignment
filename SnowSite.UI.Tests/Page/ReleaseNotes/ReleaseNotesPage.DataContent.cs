#pragma warning disable IDE1006
using HtmlElements.Elements;
using HtmlElements.Extensions;
using OpenQA.Selenium;
using SnowSite.UI.Tests.Page.Base;
using SnowSite.UI.Tests.Page.ReleaseNotes.Tab;

namespace SnowSite.UI.Tests.Page.ReleaseNotes
{
    public class ReleaseNotesPageDataContent : ElementsContainer
    {
        //elements
        private HtmlLink detailsTabControl => FindElementAs<HtmlLink>(By.XPath("//a[@class='tabHeader']/span[.='Details']"));

        public ReleaseNotesPageDataContent(IWebElement wrappedElement) : base(wrappedElement) { LogName = "Release Notes Page Data Content"; }

        //page actions
        public ReleaseNotesPageDataContentDetailsTab OpenDetailsTab()
        {
            detailsTabControl.WaitForVisible().Click();
            return new ReleaseNotesPageDataContentDetailsTab(wrappedElement.FindElement(By.XPath("//div[@data-region-name='1']")));
        }
    }
}