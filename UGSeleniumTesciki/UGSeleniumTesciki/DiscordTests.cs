using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using UGSeleniumTesciki;

namespace TestyUgSelenium
{
    [TestFixture]
    public class DiscordTests
    {
        private string DRIVER_PATH = SingletonStrings.Instance.PATH_CHROME_EXE;
        private string CURRENT_WEBSITE_ADDRESS = SingletonStrings.DISCORD_PATH;

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