using SnowSite.UI.Tests.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public UiBaseTest(UiTestAssemblyFixture uiTestAssemblyFixture, UiTestClassFixture uiTestClassFixture, ITestOutputHelper output) {
            UiTestAssemblyFixture = uiTestAssemblyFixture;
            UiTestClassFixture = uiTestClassFixture;
            TestOutput = output;

            WebContext.Initialize();
        }

        public void Dispose() {
            WebContext.Dispose();
        }
    }
}