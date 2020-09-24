using SnowSite.UI.Tests.Fixture;
using Xunit;
using Xunit.Abstractions;
using static SnowSite.UI.Tests.Step.KnowledgeBaseSteps;
using static SnowSite.UI.Tests.Step.NavigationSteps;


namespace SnowSite.UI.Tests
{
    public class NavigationTests : UiBaseTest
    {
        public NavigationTests(UiTestAssemblyFixture uiTestAssemblyFixture,
            UiTestClassFixture uiTestClassFixture,
            ITestOutputHelper output) : base(uiTestAssemblyFixture, uiTestClassFixture, output) { }

        [Theory]
        [InlineData("Snow License Manager", "Release Notes: Snow License Manager 9.7.1", "000013119")]
        [InlineData("Snow Inventory Oracle Scanner", "Release Notes: Snow Inventory Oracle Scanner 6.1.2", "000013153")]
        public void ReleaseNotesHappyPassTest(string searchText, string articleTitle, string articleNumber)
        {
            OpenGlobalCommunityPage();
            FindSuggestedInKnowledgeBase(searchText, articleTitle);
            CheckArticleProperties(articleTitle, articleNumber);
        }
    }
}
