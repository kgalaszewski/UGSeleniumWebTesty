using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UGSeleniumTesciki;

namespace TestyUgSelenium
{
    [TestFixture]
    public class WzrUgTests
    {
        private string DRIVER_PATH = SingletonStrings.Instance.PATH_CHROME_EXE;
        string CURRENT_WEBSITE_ADDRESS = SingletonStrings.WZR_UG_PATH;

        ChromeDriver chromeDriver;

        [SetUp]
        public void Setup()
        {
            chromeDriver = new ChromeDriver(DRIVER_PATH);
            chromeDriver.Url = CURRENT_WEBSITE_ADDRESS;
        }

        [Test]
        public void Check_Can_TurnBack_To_MainPage()
        {
            chromeDriver.Manage().Window.Maximize();
            IWebElement buttonStronaGlowna = chromeDriver.FindElement(By.XPath("//*[contains(text(), 'Wybierz')]"));
            buttonStronaGlowna.Click();

            Assert.Pass();
        }

        [Test]
        public void Check_If_Language_CanBeSet_To_English()
        {
            chromeDriver.Manage().Window.Maximize();
            IWebElement buttonLanguage = chromeDriver.FindElement(By.ClassName("tm_lang"));
            buttonLanguage.Click();

            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            chromeDriver.Close();
        }
    }
}