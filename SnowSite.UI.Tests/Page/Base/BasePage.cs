using HtmlElements;
using HtmlElements.Elements;
using OpenQA.Selenium.Support.UI;
using SnowSite.UI.Tests.Context;
using SnowSite.UI.Tests.Element;
using SnowSite.UI.Tests.Helper;
using SnowSite.UI.Tests.Page.Base;
using SnowSite.UI.Tests.Web;
using System;

namespace SnowSite.UI.Tests.Page
{
    public abstract class BasePage : HtmlPage, IPage
    {
        private readonly bool waitTillLoaded = RunSettingsHelper.UiSettings.GetSection("waitpagesloaded").Value.As<bool>();

        public Browser Browser;
        public string LogName { get; protected set; }   //can be used in generic log methods

        public BasePage() : base(WebContext.Instance.Browser.Driver)
        {
            Browser = WebContext.Instance.Browser;
            if (waitTillLoaded)
            {
                WaitTillLoaded();
            }
        }

        public void WaitTillLoaded()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(20)); //TODO: implement constants
            wait.Until(d => ReadyState == DocumentReadyState.Complete);
        }
    }
}
