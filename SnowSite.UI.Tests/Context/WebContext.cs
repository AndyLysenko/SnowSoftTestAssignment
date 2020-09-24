using SnowSite.UI.Tests.Web;
using System;

namespace SnowSite.UI.Tests.Context
{
    public sealed class WebContext : IDisposable
    {
        # region singleton
        private WebContext()
        {
            Browser = new BrowserFactory().GetBrowser();
        }

        private static WebContext instance = new WebContext();

        public static WebContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WebContext();
                }
                return instance;
            }
        }

        public void Dispose()
        {
            instance?.Browser?.Dispose();
            instance = null;
        }
        #endregion

        public Browser Browser { get; private set; }
    }
}
