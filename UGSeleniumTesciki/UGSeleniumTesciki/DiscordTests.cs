using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace TestyUgSelenium
{
    [TestFixture]
    public class DiscordTests
    {
        string DRIVER_PATH = "D:\\Selenium\\chromedriver_win32";
        string CURRENT_WEBSITE_ADDRESS = "https://support.discordapp.com/hc/en-us";

        ChromeDriver chromeDriver;

        [SetUp]
        public void Setup()
        {
            chromeDriver = new ChromeDriver(DRIVER_PATH);
            chromeDriver.Url = CURRENT_WEBSITE_ADDRESS;
        }

        [Test]
        public void Check_If_SearchBar_Works()
        {
            chromeDriver.Manage().Window.Maximize();            

            IWebElement queryInput = chromeDriver.FindElement(By.XPath(".//*[@id='query']"));
            queryInput.SendKeys("music bot");
            Actions builder = new Actions(chromeDriver);
            builder.SendKeys(Keys.Enter);

            Assert.Pass();
        }

        [Test]
        public void Alert()
        {
            chromeDriver.Manage().Window.Maximize();
            IWebElement buttonStronaGlowna = chromeDriver.FindElement(By.ClassName("ns-close"));
            buttonStronaGlowna.Click();

            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            chromeDriver.Close();
        }
    }
}