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

            LoginPage loginObj = new LoginPage();
            loginObj.loginStep(driver);

            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            TMPage tmObj = new TMPage();
            tmObj.createTM(driver);

            tmObj.editTM(driver);

            tmObj.deleteTM(driver);
        }
    }
}
