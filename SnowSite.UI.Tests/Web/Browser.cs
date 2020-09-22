using HtmlElements;
using OpenQA.Selenium;
using SnowSite.UI.Tests.Page;
using System;

namespace SnowSite.UI.Tests.Web
{
    public class Browser : IDisposable
    {
        private IPage currentPage;
        public Browser(IWebDriver driver)
        {
            Driver = driver;
            Driver.Manage().Window.Maximize();
        }

        public IWebDriver Driver { get; private set; }

        public void Initialize<T>() where T : IPage
        {
            IPageObjectFactory pageObjectFactory = new PageObjectFactory();
            currentPage = pageObjectFactory.Create<T>(Driver);
        }

        public T GetPage<T>() where T : IPage
        {
            if (currentPage == null || currentPage.GetType() != typeof(T))
            {
                Initialize<T>();
            }
            return GetCurrentPage<T>();
        }

        public T GetCurrentPage<T>() => (T)currentPage;

        public void Dispose()
        {
            try
            {
                Driver.Quit();
                Driver.Dispose();
            }
            catch (ObjectDisposedException)
            {
                // already disposed, so nothing to do
            }
        }

        public void GoTo(string url) => Driver.Navigate().GoToUrl(url);
    }
}
