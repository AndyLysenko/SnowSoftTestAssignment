using HtmlElements.Elements;
using OpenQA.Selenium;
using System;

namespace SnowSite.UI.Tests.Element
{
    public static class CastExtensions
    {
        public static T As<T>(this IWebElement element) where T : HtmlElement => (T)Activator.CreateInstance(typeof(T), new object[] { element });
    }
}
