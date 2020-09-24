using HtmlElements.Elements;
using HtmlElements.Extensions;
using OpenQA.Selenium;

namespace SnowSite.UI.Tests.Page.ReleaseNotes
{
    public class ReleaseNotesPage : BasePage
    {
        //page components
        public ReleaseNotesPageHeader Header => new ReleaseNotesPageHeader(FindElement(By.ClassName("header")));
        public ReleaseNotesPageDataHeader DataHeader => new ReleaseNotesPageDataHeader(FindElement(By.XPath("//div[@data-region-name='header']")));
        public ReleaseNotesPageDataContent DataContent => new ReleaseNotesPageDataContent(FindElement(By.XPath("//div[@data-region-name='content']")));
        public HtmlElement DataFooter => new HtmlElement(FindElement(By.XPath("//div[@data-region-name='footer']")));   //not implemented

        public ReleaseNotesPage() : base() { LogName = "Release Notes Page"; }

        //page actions
        public new ReleaseNotesPage WaitTillLoaded()
        {
            //mverifies page is open. can be extended if needed 
            DataHeader.WaitForVisible();
            DataContent.WaitForVisible();
            return this;
        }

        public string GetArticleTitleFromContentHeader() => DataHeader.GetArticleTitle();
        public string GetArticleNumberFromContentHeader() => DataHeader.GetArticleNumber();
    }
}
