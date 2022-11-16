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

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Url = "https://totaltavern.com/";
        }

        [Test]
        public void NavigateToWebsite()
        {
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);

            driver.FindElement(By.XPath("//*[@id=\"navbarSupportedContent\"]/ul/li[1]/a")).Click();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}