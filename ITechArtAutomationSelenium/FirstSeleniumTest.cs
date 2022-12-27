using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ITechArtAutomationSelenium
{
    public class FirstSeleniumTest
    {
        [Test]
        public void FirstTest()
        {
            var pathToChromeDriver = Path.Combine(AppContext.BaseDirectory, "Resources", "chromedriver.exe");
            IWebDriver webDriver = new ChromeDriver(pathToChromeDriver);
            var BaseUrl = "https://www.demoblaze.com/index.html";
            var baseUrlobj = new Uri(BaseUrl, UriKind.Absolute);
            webDriver.Navigate().GoToUrl(baseUrlobj);
            webDriver.Quit(); //close the browser
            // webDriver.Close(); close the tab in browser

        }

    }
}