using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA
{
    [TestFixture]
    public class TextBoxTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void FillTextBoxesAndSubmitForm()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/text-box");

            // Input test data into text boxes
            IWebElement fullName = driver.FindElement(By.Id("userName"));
            fullName.SendKeys("Jonas Jonaitis");

            IWebElement email = driver.FindElement(By.Id("userEmail"));
            email.SendKeys("jon@test.com");

            IWebElement currentAddress = driver.FindElement(By.Id("currentAddress"));
            currentAddress.SendKeys("Vilnius");

            IWebElement permanentAddress = driver.FindElement(By.Id("permanentAddress"));
            permanentAddress.SendKeys("Kaunas");

            // Click Submit button
            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();

            // Verify that the data was entered and displayed correctly
            Assert.AreEqual("Name:Jonas Jonaitis", driver.FindElement(By.Id("name")).Text);
            Assert.AreEqual("Email:jon@test.com", driver.FindElement(By.Id("email")).Text);
            Assert.AreEqual("Current Address :Vilnius", driver.FindElement(By.CssSelector("#output div:nth-child(3)")).Text);
            Assert.AreEqual("Permanent Address :Kaunas", driver.FindElement(By.CssSelector("#output div:nth-child(4)")).Text);
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}