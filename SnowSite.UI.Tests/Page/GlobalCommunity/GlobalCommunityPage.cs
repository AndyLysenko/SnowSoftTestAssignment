using HtmlElements.Extensions;
using OpenQA.Selenium;
using SnowSite.UI.Tests.Context;
using SnowSite.UI.Tests.Page.Base;
using SnowSite.UI.Tests.Page.ReleaseNotes;
using SnowSite.UI.Tests.Validation;
using SnowSite.UI.Tests.Web.Extension.Element;

namespace SnowSite.UI.Tests.Page.GlobalCommunity
{
    public class GlobalCommunityPage : BasePage
    {
        //page components
        public GlobalCommunityPageHeader Header => new GlobalCommunityPageHeader(FindElement(By.ClassName("header")));
        public GlobalCommunityPageHero Hero => new GlobalCommunityPageHero(FindElement(By.ClassName("hero")));
        public GlobalCommunityPageHeader BodySection => new GlobalCommunityPageHeader(FindElement(By.ClassName("body")));
        public GlobalCommunityPageHeader Footer => new GlobalCommunityPageHeader(FindElement(By.ClassName("footer")));

        public GlobalCommunityPage() : base() { LogName = "Global Community Page"; }

        public new GlobalCommunityPage WaitTillLoaded()
        {
            TestContext.Instance.Logger.BreakLine().WriteLine("Check title of 'Global Comunity' page.");
            Check.Equal("Welcome to Snow Globe", Hero.GetTitle());
            return this;
        }

        //page actions
        public ReleaseNotesPage OpenReleaseNotesPageBySuggestion(string searchText, string suggestionText)
        {
            ElementsContainer suggestionsList = Hero.TypeInSearchBox(searchText).WaitForVisible();
            return suggestionsList.SelectOption_OpenPage<ReleaseNotesPage>(suggestionText);
        }
    }
}
