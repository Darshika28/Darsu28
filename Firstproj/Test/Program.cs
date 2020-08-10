using Firstproj.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Firstproj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Init and Launch Chrome
            IWebDriver driver = new ChromeDriver();

            // Login page object init and definition
            LoginPage loginObj = new LoginPage();
            loginObj.loginStep(driver);

            // Init and define home page object
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // Init and define TM page object
            TMPage tmObj = new TMPage();

            // create new record
            tmObj.createTM(driver);

            // Edit existing record
            tmObj.editTM(driver);

            // Delete existing record
            tmObj.deleteTM(driver);
        }
    }
}
