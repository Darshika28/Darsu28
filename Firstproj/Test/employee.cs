using Firstproj.Helper;
using Firstproj.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firstproj.Test
{
    [TestFixture]
    [Parallelizable]
    class employee : CommonDriver
    {
    
        [Test, Order(1), Description("Check if the user is able to create valid data")]
        public void CreateEmployee_Test()
        {
            // Init and define home page object
            HomePage homeObj = new HomePage();
            homeObj.NavigateToEmployee(driver);

            // Init and define Employee page object
            employeePage empObj = new employeePage();

            // create new record
            empObj.createEmployee(driver);
        }

        [Test, Order(2), Description("Check if the user is able to Edit Existing data")]
        public void EditEmployee_Test()
        {
            // Init and define home page object
            HomePage homeObj = new HomePage();
            homeObj.NavigateToEmployee(driver);

            // Init and define Employee page object
            employeePage empObj = new employeePage();

            // Edit existing record
            empObj.editEmployee(driver);

        }

        [Test, Order(3), Description("Check if the user is able to Delete existing data")]
        public void DeleteEmployee_Test()
        {
            // Init and define home page object
            HomePage homeObj = new HomePage();
            homeObj.NavigateToEmployee(driver);

            // Init and define Employee page object
            employeePage empObj = new employeePage();

            // Delete existing record
            empObj.deleteEmployee(driver);
        }

 
    }
}
