using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.WebDriver.SelfHealing;

namespace Sample.NUnit
{
    internal class GettingStarted
    {
        [Test]
        public void SelfHealingDriverSample()
        {
            var options = new ChromeOptions();
            var chromeDriver = new ChromeDriver(options);

            // Now create self-healing WebDriver
            var selfHealingDriver = chromeDriver.ToSelfHealingDriver();

            try
            {
                selfHealingDriver
                    .Navigate()
                    .GoToUrl("https://www.nuget.org/packages/Selenium.WebDriver.SelfHealing");

                var frameworksTabSelector = By.CssSelector("#supportedframeworks-body-tab");
                var frameworksTabHyperlink = selfHealingDriver.FindElement(frameworksTabSelector);
                var expectedTitle = frameworksTabHyperlink.Text;

                // Now modify the page source manually
                IJavaScriptExecutor js = selfHealingDriver;
                js.ExecuteScript(
                    "arguments[0].setAttribute('id', 'some-id-was-changed')", 
                    frameworksTabHyperlink);

                // Catch failure using standard WebDriver
                // This is to demonstrate failure 
                Assert.Throws<NoSuchElementException>(() =>
                {
                    // You can access the original WebDriver through the DeleteWebDriver property
                    // Here we are using it to make a call with no self-healing.
                    // It's expected to fail!
                    var originalChromeWebDriver = selfHealingDriver.DelegateWebDriver;

                    originalChromeWebDriver.FindElement(frameworksTabSelector);
                });

                // Now we will demonstrate self-healing in action
                // Using the Self-healing WebDriver this same search will succeed.
                // After test execution, review the logs.
                var healedElement = selfHealingDriver.FindElement(frameworksTabSelector);
                var actualTitle = healedElement.Text;

                // Now perform some assertions
                Assert.AreEqual(actualTitle, expectedTitle);
                Assert.AreEqual(frameworksTabHyperlink, healedElement);
            }
            finally
            {
                // Clean up the driver afterward
                // This will dispose the delegate WebDriver also
                selfHealingDriver.Dispose();
            }
        }
    }
}