#pragma warning disable IDE1006
using HtmlElements.Elements;
using OpenQA.Selenium;
using SnowSite.UI.Tests.Page.Base;

namespace SnowSite.UI.Tests.Page.ReleaseNotes
{
    public class ReleaseNotesPageDataHeader : ElementsContainer
    {
        //elements
        private HtmlLabel articleTitle => FindElementAs<HtmlLabel>(By.ClassName("slds-page-header__title"));
        private HtmlLabel articleNumber => FindElementAs<HtmlLabel>(By.XPath("//span[@title='Article Number']/following-sibling::div"));

        public ReleaseNotesPageDataHeader(IWebElement wrappedElement) : base(wrappedElement) { LogName = "Release Notes Page Header"; }

        //page actions
        public string GetArticleTitle() => articleTitle.TextContent;
        public string GetArticleNumber() => articleNumber.TextContent;
    }
}