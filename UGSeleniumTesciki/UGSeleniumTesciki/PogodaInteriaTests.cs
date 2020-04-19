using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using UGSeleniumTesciki;

namespace TestyUgSelenium
{
    [TestFixture]
    public class PogodaInteriaTests
    {
        private string DRIVER_PATH = SingletonStrings.Instance.PATH_CHROME_EXE;
        string CURRENT_WEBSITE_ADDRESS = SingletonStrings.POGODA_INTERIA_PATH;

        ChromeDriver chromeDriver;

        [SetUp]
        public void Setup()
        {
            chromeDriver = new ChromeDriver(DRIVER_PATH);
            chromeDriver.Url = CURRENT_WEBSITE_ADDRESS;
        }

        [Test]
        public void Check_If_CurrentTemperature_Is_Displayed_Properly_InCelsius()
        {
            chromeDriver.Manage().Window.Maximize();
            IWebElement temperature = chromeDriver.FindElement(By.ClassName("weather-currently-temp-strict"));
            var temperatureResult = temperature.Text;

            Assert.IsTrue(temperatureResult.Contains("C") && !temperatureResult.Contains("F"));
        }

        [Test]
        public void Check_If_ItsPossible_To_ReturnToMainPage()
        {
            chromeDriver.Manage().Window.Maximize();
            IWebElement buttonStronaGlowna = chromeDriver.FindElement(By.ClassName("common-header__service-logo"));
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
