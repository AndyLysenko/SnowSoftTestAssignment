using SnowSite.UI.Tests.Page.GlobalCommunity;
using SnowSite.UI.Tests.Page.Home;
using SnowSite.UI.Tests.Web;

namespace SnowSite.UI.Tests.Step
{
    public static class NavigationSteps
    {
        public static HomePage OpenHomePage()
        {
            return Activator.Get<HomePage>();
        }

        public static GlobalCommunityPage OpenGlobalCommunityPage()
        {
            return OpenHomePage().OpenGlobalCommunityPage();
        }
    }
}
