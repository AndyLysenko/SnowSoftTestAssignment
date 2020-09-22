using HtmlElements.Elements;
using HtmlElements.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SnowSite.UI.Tests.Web;
using System.Linq;

namespace SnowSite.UI.Tests.Page
{
    public class GlobalCommunityPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//h2[.='Welcome to Snow Globe']")]
        private readonly HtmlLabel pageTitle;

        [FindsBy(How = How.XPath, Using = "//div[@data-region-name='themeHero']//input")]
        private readonly HtmlInput mainSearchBox;

        [FindsBy(How = How.XPath, Using = "//div[@data-region-name='themeHero']//div[@class='result-container']")]
        private readonly HtmlLabel searchSuggestionResults;


        //private readonly By searchSuggestionElementLocator = By.XPath("//div[@data-region-name='themeHero']//a/div/span[@data-aura-class='uiOutputText']");
        private readonly By searchSuggestionElementLocator = By.XPath("//a/div/span[@data-aura-class='uiOutputText']");

        public GlobalCommunityPage() : base()
        {
            Name = "Global Community Page";
        }

        public new GlobalCommunityPage WaitTillLoaded()
        {
            //base.WaitTillLoaded();
            pageTitle.WaitForVisible(); // make sure page is open. can be extended if needed 
            return this;
        }

        public GlobalCommunityPage StartSearch(string topic)
        {
            mainSearchBox.EnterText(topic);
            return this;
        }

        public TPage SelectOptionOpenPage<TPage>(string optionText) where TPage : IPage
        {
            System.Collections.Generic.IList<HtmlLabel> els = searchSuggestionResults.WaitForVisible().FindElements<HtmlLabel>(searchSuggestionElementLocator);
            HtmlLabel el = els.First(e => e.TextContent.Equals(optionText));
            el?.WaitForVisible().Click();
            return Activator.Get<TPage>(); ;
        }



    }
}
