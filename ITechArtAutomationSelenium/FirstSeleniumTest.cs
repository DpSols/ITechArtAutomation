using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ITechArtAutomationSelenium
{
    [TestFixture]
    public class FirstSeleniumTest
    {
        private IWebDriver webDriver { get; set; }
        private readonly string _baseUrl = Configurator.BaseUrl;

        [SetUp]
        public void SetUp()
        {
            var pathToChromeDriver = Path.Combine(AppContext.BaseDirectory, "Resources", "chromedriver.exe");
            webDriver = new ChromeDriver(pathToChromeDriver);
        }
        [Test]
        public void FirstTest()
        {
            var baseUrlobj = new Uri(_baseUrl, UriKind.Absolute);
            webDriver.Navigate().GoToUrl(baseUrlobj);
        }

        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }

    }
}