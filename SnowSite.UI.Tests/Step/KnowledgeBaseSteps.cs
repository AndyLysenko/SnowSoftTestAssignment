using SnowSite.UI.Tests.Page;
using SnowSite.UI.Tests.Web;
using Xunit;

namespace SnowSite.UI.Tests.Step
{
    public static class KnowledgeBaseSteps
    {
        public static void FindSuggestedInKnowledgeBase(string searchText, string topic)
        {
            GlobalCommunityPage.StartSearch(searchText).SelectOptionOpenPage<ReleaseNotesSnowLicenseManager971Page>(topic);
        }

        public static void CheckArticleProperties(string topic, string articleNumber)
        {
            ReleaseNotesSnowLicenseManager971Page releaseNotesSnowLicenseManager971Page
                = Activator.Get<ReleaseNotesSnowLicenseManager971Page>().WaitTillLoaded();

            Assert.Equal(topic, releaseNotesSnowLicenseManager971Page.GetPageTitle());
            Assert.Equal(articleNumber, releaseNotesSnowLicenseManager971Page.GetArticleNumber());
        }

        private static GlobalCommunityPage GlobalCommunityPage => Activator.Get<GlobalCommunityPage>().WaitTillLoaded();
    }
}
