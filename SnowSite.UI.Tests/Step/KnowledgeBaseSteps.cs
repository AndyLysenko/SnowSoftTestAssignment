using SnowSite.UI.Tests.Context;
using SnowSite.UI.Tests.Logger;
using SnowSite.UI.Tests.Page.GlobalCommunity;
using SnowSite.UI.Tests.Page.ReleaseNotes;
using SnowSite.UI.Tests.Page.ReleaseNotes.Tab;
using SnowSite.UI.Tests.Validation;
using SnowSite.UI.Tests.Web;

namespace SnowSite.UI.Tests.Step
{
    public static class KnowledgeBaseSteps
    {
        private static ILogger Logger => TestContext.Instance.Logger;

        public static void FindSuggestedInKnowledgeBase(string searchText, string suggestedText)
        {
            GlobalCommunityPage.OpenReleaseNotesPageBySuggestion(searchText, suggestedText);
        }

        public static void CheckArticleProperties(string articleTitle, string articleNumber)
        {
            ReleaseNotesPage releaseNotesPage
                = Activator.Get<ReleaseNotesPage>().WaitTillLoaded();

            //check in content header
            Logger.BreakLine().WriteLine("Validate article properties on page header.");
            Check.Equal(articleTitle, releaseNotesPage.GetArticleTitleFromContentHeader());
            Check.Equal(articleNumber, releaseNotesPage.GetArticleNumberFromContentHeader());

            //check in details
            Logger.BreakLine().WriteLine("Validate article properties on content section.");
            ReleaseNotesPageDataContentDetailsTab detailsTab = releaseNotesPage.DataContent.OpenDetailsTab();
            Check.Equal(articleTitle, detailsTab.GetArticleTitle());
            Check.Equal(articleNumber, detailsTab.GetArticleNumber());

            // check tab name
            Logger.BreakLine().WriteLine("Validate tab title.");
            Check.Equal(articleTitle, releaseNotesPage.Title);
        }

        private static GlobalCommunityPage GlobalCommunityPage => Activator.Get<GlobalCommunityPage>().WaitTillLoaded();
    }
}
