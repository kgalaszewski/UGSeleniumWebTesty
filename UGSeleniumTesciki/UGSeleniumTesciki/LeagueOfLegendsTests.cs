using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;

namespace TestyUgSelenium
{
    [TestFixture]
    public class LeagueOfLegendsTests
    {
        string CURRENT_WEBSITE_ADDRESS = "https://auth.riotgames.com/login#client_id=rso-web-client-prod&login_hint=eune&redirect_uri=https%3A%2F%2Flogin.leagueoflegends.com%2Foauth2-callback&response_type=code&scope=openid&state=yEMI3eYDKlVzhovK4CRsxIZxf0JVEXSbc6r5rDg9byQ&ui_locales=en-pl";
        string DRIVER_PATH = "D:\\Selenium\\chromedriver_win32";

        ChromeDriver chromeDriver;

        [SetUp]
        public void Setup()
        {
            chromeDriver = new ChromeDriver(DRIVER_PATH);
            chromeDriver.Url = CURRENT_WEBSITE_ADDRESS;
        }

        [Test]
        public void Verify_LoginForm_Works()
        {
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.FindElement(By.Name("username")).SendKeys("username");
            chromeDriver.FindElement(By.Name("password")).SendKeys("password");
            chromeDriver.FindElement(By.ClassName("mobile-button__submit")).Click();

            Assert.Pass();
        }

        [TestCase("", "123")]
        [TestCase("", "")]
        [TestCase("123", "")]
        public void Verify_LoginForm_CantBeSubbmited_WithoutPassOrUserName(string username, string password)
        {
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.FindElement(By.Name("username")).SendKeys(username);
            chromeDriver.FindElement(By.Name("password")).SendKeys(password);

            var isSubmitButtonDisabled = chromeDriver.FindElement(By.ClassName("mobile-button__submit")).GetAttribute("class").Contains("disabled");

            Assert.IsTrue(isSubmitButtonDisabled);
        }

        [Test]
        public async Task Verify_LoginForm_Validation_Works()
        {
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.FindElement(By.Name("username")).SendKeys("INVALID_USERNAME");
            chromeDriver.FindElement(By.Name("password")).SendKeys("INVALID_PASSWORD");
            chromeDriver.FindElement(By.ClassName("mobile-button__submit")).Click();

            await Task.Delay(1000);

            var cantSignInButton = chromeDriver.FindElement(By.XPath(".//*[@data-testid='cant-sign-in']"));

            Assert.IsTrue(cantSignInButton.Displayed);            
        }

        [TearDown]
        public void TearDown()
        {
            chromeDriver.Close();
        }
    }
}
