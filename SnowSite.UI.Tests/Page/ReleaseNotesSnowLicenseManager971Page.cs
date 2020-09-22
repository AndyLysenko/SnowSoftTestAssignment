using HtmlElements.Elements;
using HtmlElements.Extensions;
using OpenQA.Selenium.Support.PageObjects;

namespace SnowSite.UI.Tests.Page
{
    public class ReleaseNotesSnowLicenseManager971Page : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = ".slds-page-header__title")]
        private readonly HtmlLabel pageTitle;

        [FindsBy(How = How.XPath, Using = "//span[@title='Article Number']")]
        private readonly HtmlLabel bannerArticleNumber;

        [FindsBy(How = How.CssSelector, Using = ".article-head")]
        private readonly HtmlLabel articleTitle;

        public ReleaseNotesSnowLicenseManager971Page() : base() { }

        public new ReleaseNotesSnowLicenseManager971Page WaitTillLoaded()
        {
            pageTitle.WaitForVisible();    // make sure page is open. can be extended if needed 
            articleTitle.WaitForVisible();
            return this;
        }

        public string GetPageTitle() => pageTitle.TextContent;

        public string GetArticleNumber()
        {
            HtmlLabel articleNumber = new HtmlLabel(bannerArticleNumber.WaitForPresent().NextSibling);
            return articleNumber.WaitForVisible().TextContent;
        }
    }
}
