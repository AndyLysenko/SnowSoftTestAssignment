#pragma warning disable IDE1006, IDE0051
using HtmlElements.Elements;
using OpenQA.Selenium;
using SnowSite.UI.Tests.Page.Base;

namespace SnowSite.UI.Tests.Page.GlobalCommunity
{
    public class GlobalCommunityPageHero : ElementsContainer
    {
        //elements
        private HtmlLabel title => FindElementAs<HtmlLabel>(By.TagName("h2"));
        private HtmlInput searchInput => FindElementAs<HtmlInput>(By.TagName("input"));
        private HtmlLink searchButton => FindElementAs<HtmlLink>(By.TagName("button"));

        public GlobalCommunityPageHero(IWebElement wrappedElement) : base(wrappedElement) { LogName = "Global Community Page Hero"; }

        //page actions
        public string GetTitle() => title.TextContent;

        public ElementsContainer TypeInSearchBox(string topic)
        {
            searchInput.EnterText(topic);
            return FindElementAs<ElementsContainer>(By.ClassName("result-container"));
        }
    }
}