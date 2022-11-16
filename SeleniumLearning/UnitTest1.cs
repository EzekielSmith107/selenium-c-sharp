using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://totaltavern.com/";
        }

        [TearDown]
        public void CloseBrowser()
        {
            TestContext.Progress.WriteLine("Tear down executed.");
        }
    }
}