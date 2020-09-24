#pragma warning disable IDE1006
using HtmlElements.Elements;
using HtmlElements.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SnowSite.UI.Tests.Context;
using SnowSite.UI.Tests.Element;
using SnowSite.UI.Tests.Page.Base;

namespace SnowSite.UI.Tests.Web.Extension.Element
{
    public static class ActionExtensions
    {
        private static IWebDriver driver => WebContext.Instance.Browser.Driver;

        public static TPage OpenSubMenuItemBy<TPage>(this HtmlElement menuElement, By subMenuItemLocator) where TPage : IPage
            => menuElement.OpenSubMenuItem<TPage>(subMenuItemLocator);

        public static TPage OpenSubMenuItem<TPage>(this HtmlElement menuElement, By subMenuItemLocator) where TPage : IPage
        {
            menuElement.MouseHover_SubMenuClick(subMenuItemLocator);
            return Activator.Get<TPage>();
        }

        public static T FindElementAs<T>(this IWebElement element, By by) where T : HtmlElement => element.FindElement(by).As<T>();

        public static void MouseHover_SubMenuClick(this HtmlElement element, By by)
        {
            //Doing a MouseHover  
            Actions action = new Actions(driver);
            action.MoveToElement(element.WaitForVisible()).Perform();

            //Clicking the SubMenu on MouseHover   
            IWebElement menuelement = driver.FindElement(by);
            menuelement.Click();
        }

        public static TPage SelectOption_OpenPage<TPage>(this ElementsContainer optionsList, string optionPartialText) where TPage : IPage
        {
            IWebElement element = optionsList.WrappedElement.WaitForVisible().FindElementAs<HtmlElement>(By.XPath($"//li[contains(., '{optionPartialText}')]"));
            element.WaitForVisible().Click();
            return Activator.Get<TPage>();
        }
    }
}
