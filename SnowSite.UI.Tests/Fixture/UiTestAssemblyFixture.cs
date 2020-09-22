using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SnowSite.UI.Tests.Fixture
{
    public class UiTestAssemblyFixture: IDisposable
    {
        public UiTestAssemblyFixture() { }

        public void Dispose() { }

        #region Test Assembly Collection Definition
        [CollectionDefinition("UI.Test Collection")]
        public class UiTestAssemblyCollection : ICollectionFixture<UiTestAssemblyFixture> { }
        #endregion
    }
}