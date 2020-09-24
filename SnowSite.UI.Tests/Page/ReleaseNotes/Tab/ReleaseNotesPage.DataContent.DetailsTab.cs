#pragma warning disable IDE1006
using HtmlElements.Elements;
using OpenQA.Selenium;
using SnowSite.UI.Tests.Page.Base;

namespace SnowSite.UI.Tests.Page.ReleaseNotes.Tab
{
    public class ReleaseNotesPageDataContentDetailsTab : ElementsContainer
    {
        //elements
        private HtmlLabel articleTitle => FindElementAs<HtmlLabel>(By.TagName("h1"));
        private HtmlLabel articleNumber => FindElementAs<HtmlLabel>(By.XPath("//div[span[.='Article Number']]/following-sibling::div"));

        public ReleaseNotesPageDataContentDetailsTab(IWebElement wrappedElement) : base(wrappedElement) { LogName = "Release Notes Page Data Content Details Tab"; }

        //page actions
        public string GetArticleTitle() => articleTitle.TextContent;
        public string GetArticleNumber() => articleNumber.TextContent;
    }
}