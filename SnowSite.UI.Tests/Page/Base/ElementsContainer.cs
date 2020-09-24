using HtmlElements.Elements;
using OpenQA.Selenium;
using SnowSite.UI.Tests.Element;

namespace SnowSite.UI.Tests.Page.Base
{
    public class ElementsContainer : HtmlElement, IElementsContainer
    {
        protected readonly IWebElement wrappedElement;

        public ElementsContainer(IWebElement wrappedElement) : base(wrappedElement)
        {
            this.wrappedElement = wrappedElement;
        }

        protected T FindElementAs<T>(By by) where T : HtmlElement => wrappedElement.FindElement(by).As<T>();

        public string LogName { get; protected set; }   //can be used in generic log methods
    }
}
