using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestyUgSelenium
{
    [TestFixture]
    public class WzrUgTests
    {
        string CURRENT_WEBSITE_ADDRESS = "https://wzr.ug.edu.pl/studia/index.php?str=1879";
        string DRIVER_PATH = "D:\\Selenium\\chromedriver_win32";

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