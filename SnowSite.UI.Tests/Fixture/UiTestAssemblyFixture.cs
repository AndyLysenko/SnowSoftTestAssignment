using System;
using Xunit;

namespace SnowSite.UI.Tests.Fixture
{
    public class UiTestAssemblyFixture : IDisposable
    {
        public UiTestAssemblyFixture() { }

        public void Dispose() { }

        #region Test Assembly Collection Definition
        [CollectionDefinition("UI.Test Collection")]
        public class UiTestAssemblyCollection : ICollectionFixture<UiTestAssemblyFixture> { }
        #endregion
    }
}