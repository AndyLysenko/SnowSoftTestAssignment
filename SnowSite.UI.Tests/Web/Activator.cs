using SnowSite.UI.Tests.Context;
using SnowSite.UI.Tests.Page.Base;

namespace SnowSite.UI.Tests.Web
{
    public class Activator
    {
        public static T Get<T>() where T : IPage => WebContext.Instance.Browser.GetPage<T>();
    }
}
