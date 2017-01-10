using System;
using OpenQA.Selenium.Appium;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;

namespace Glyco_UI_tests.Setups
{
    /// <summary>
    /// This is a base class, which using for inheritance for all test suites
    /// </summary>
    [SetUpFixture]
    public class TestSetUp
    {
        internal AndroidDriver<AppiumWebElement> driver;

        /// <summary>
        /// This part will be executed before each test suite
        /// </summary>
        [OneTimeSetUp]
        public void BeforeAll()
        {
            //Declare capabilities for Appium server
            DesiredCapabilities capabilities = new DesiredCapabilities();

            //Way where located current apk file
            capabilities.SetCapability("app", "C:\\Quality-Assurance-Engineer-Challenge\\glyco_test.apk");

            //Id of connected device. It could be replaced on the name of emulator
            capabilities.SetCapability("deviceName", "3300479fbe0a33a1");

            //Type of platform
            capabilities.SetCapability("platformName", "Android");

            //Create a new android driver
            driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.01:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(180));

            //Set timeout for waiting each element as 5 seconds
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        /// <summary>
        /// This part will be executed after each test suite
        /// </summary>
        [OneTimeTearDown]
        public void AfterAll()
        {
            driver.CloseApp();
            driver.RemoveApp("com.holmusk.glycoleap");
            driver.Quit();
        }

        /// <summary>
        /// This part will be executed after each test case
        /// </summary>
        [TearDown]
        public void TearDowwn()
        {
            if (driver != null)
            {
                driver.ResetApp();
            }
        }
    }
}
