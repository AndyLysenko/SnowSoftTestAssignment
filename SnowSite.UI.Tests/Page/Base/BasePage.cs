using HtmlElements;
using HtmlElements.Elements;
using OpenQA.Selenium.Support.UI;
using SnowSite.UI.Tests.Context;
using SnowSite.UI.Tests.Web;
using System;

namespace SnowSite.UI.Tests.Page
{
    public abstract class BasePage : HtmlPage, IPage
    {
        public BasePage() : base(WebContext.Browser.Driver)
        {
            Browser = WebContext.Browser;
            //WaitTillLoaded();
        }

        public Browser Browser;
        public string Name { get; protected set; }

        public void WaitTillLoaded()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(20)); //TODO: implement constants
            wait.Until(d => ReadyState == DocumentReadyState.Complete);
        }


    }
}
