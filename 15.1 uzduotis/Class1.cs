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
            driver.Navigate().GoToUrl("https://demoqa.com/text-box");
        }

        [Test]
        public void FillTextBoxesAndSubmitForm()
        {
            // Input test data into text boxes
            IWebElement fullName = driver.FindElement(By.Id("userName"));
            fullName.SendKeys("John Doe");

            IWebElement email = driver.FindElement(By.Id("userEmail"));
            email.SendKeys("johndoe@test.com");

            IWebElement currentAddress = driver.FindElement(By.Id("currentAddress"));
            currentAddress.SendKeys("123 Main St");

            IWebElement permanentAddress = driver.FindElement(By.Id("permanentAddress"));
            permanentAddress.SendKeys("456 Oak Ave");

            // Click Submit button
            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();

            // Verify that the data was entered and displayed correctly
            Assert.AreEqual("Name:John Doe", driver.FindElement(By.Id("name")).Text);
            Assert.AreEqual("Email:johndoe@test.com", driver.FindElement(By.Id("email")).Text);
            Assert.AreEqual("Current Address :123 Main St", driver.FindElement(By.CssSelector("#output div:nth-child(3)")).Text);
            Assert.AreEqual("Permananet Address :456 Oak Ave", driver.FindElement(By.CssSelector("#output div:nth-child(4)")).Text);
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}