using SnowSite.UI.Tests.Context;
using SnowSite.UI.Tests.Logger;
using System;
using Xunit;
using Xunit.Abstractions;

namespace SnowSite.UI.Tests.Fixture
{
    [Collection("UI.Test Collection")]
    public class UiBaseTest : IClassFixture<UiTestClassFixture>, IDisposable
    {
        protected UiTestAssemblyFixture UiTestAssemblyFixture;
        protected UiTestClassFixture UiTestClassFixture;

        public ITestOutputHelper TestOutput { get; private set; }

        public UiBaseTest(UiTestAssemblyFixture uiTestAssemblyFixture, UiTestClassFixture uiTestClassFixture, ITestOutputHelper output)
        {
            UiTestAssemblyFixture = uiTestAssemblyFixture;
            UiTestClassFixture = uiTestClassFixture;
            TestOutput = output;

            TestContext.Instance.SetLogger(new ConsoleLogger(output)).WriteLine("Test Started.");
        }

        public void Dispose()
        {
            CheckTestResult();
            WebContext.Instance.Dispose();
            TestContext.Instance.Dispose();
        }

        private void CheckTestResult()
        {
            if (TestContext.Instance.CurrentTestResult)
            {
                TestContext.Instance.Logger.BreakLine().WriteLine("Test Passed.");
            }
            else
            {
                TestContext.Instance.Logger.BreakLine().WriteLine("Test Failed. Check logs for details.");
                Assert.True(false, "Test Failed. Check logs for details.");
            }
        }
    }
}