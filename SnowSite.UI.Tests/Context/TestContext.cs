using SnowSite.UI.Tests.Logger;
using System;

namespace SnowSite.UI.Tests.Context
{
    public sealed class TestContext : IDisposable
    {
        # region singleton
        private TestContext() { }

        private static TestContext instance = new TestContext();

        public static TestContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TestContext();
                }
                return instance;
            }
        }

        public void Dispose()
        {
            instance = null;
        }
        #endregion

        public ILogger Logger { get; private set; }
        public bool CurrentTestResult { get; set; } = true;

        public ILogger SetLogger(ILogger logger)
        {
            Logger = logger;
            return Logger;
        }
    }
}
