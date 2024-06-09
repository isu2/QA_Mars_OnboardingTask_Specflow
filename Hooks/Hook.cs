using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BoDi;

namespace QA_Mars_OnboardingTaskSpecflow.Hooks
{
    [Binding]
    public class Hooks
    {
        private static IWebDriver driver;
        private readonly IObjectContainer container;

        public Hooks(IObjectContainer container)
        {
            this.container = container;
        }

        [BeforeTestRun]
        public static void CreateWebDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [BeforeScenario]
        public void AddWebDriverToContainer()
        {
            container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterTestRun]
        public static void DestroyWebDriver()
        {
            driver.Quit();
        }
    }
}
