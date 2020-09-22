using HtmlElements.Elements;
using HtmlElements.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SnowSite.UI.Tests.Context;

namespace SnowSite.UI.Tests.Element
{
    public static class ActionExtensions
    {
        private static IWebDriver driver => WebContext.Browser.Driver;

        public static void MouseHover_SubMenuClick(this HtmlElement element, By by)
        {
            //Doing a MouseHover  
            Actions action = new Actions(driver);
            action.MoveToElement(element.WaitForVisible()).Perform();

            //Clicking the SubMenu on MouseHover   
            IWebElement menuelement = driver.FindElement(by);
            menuelement.Click();
        }
    }
}
