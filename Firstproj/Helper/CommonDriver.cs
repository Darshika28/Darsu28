using Firstproj.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firstproj.Helper
{
    class CommonDriver
    {
        // Init Chrome
        public IWebDriver driver;


        [OneTimeSetUp]
        public void loginActions()
        {
            //Define WebDriver
            driver = new ChromeDriver();

            // Login page object init and definition
            LoginPage loginObj = new LoginPage();
            loginObj.loginStep(driver);
         
        }

        [OneTimeTearDown]
        public void ClosingStep()
        {
            // Kills Drivers Instances
            driver.Quit();
        }


    }
}
