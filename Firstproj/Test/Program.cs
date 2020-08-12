using Firstproj.Helper;
using Firstproj.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Firstproj
{
    [TestFixture]
    [Parallelizable]
    class Program : CommonDriver
    {
      
        [Test, Description("Check if the user is able to create valid data")]
        public void CreateTM_Test()
        {
            // Init and define home page object
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // Init and define TM page object
            TMPage tmObj = new TMPage();

            // create new record
            tmObj.createTM(driver);
        }

        [Test, Description("Check if the user is able to Edit existing data")]
        public void EditTM_Test()
        {
            // Init and define home page object
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // Init and define TM page object
            TMPage tmObj = new TMPage();

            // Edit existing record
            tmObj.editTM(driver);

        }

        [Test, Description("Check if the user is able to delete existing data")]
        public void DeleteTM_Test()
        {
            // Init and define home page object
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // Init and define TM page object
            TMPage tmObj = new TMPage();

            // Delete existing record
            tmObj.deleteTM(driver);
        }


    }
}
