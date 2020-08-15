using Firstproj.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Firstproj
{
    class employeePage
    {
        //Function to create Employee

        public void createEmployee(IWebDriver driver)
        {
            // Find and click on create button
            HomePage homeObj = new HomePage();
            homeObj.ClickOnCreate(driver);

            // validation of Creating new time and Material Record

            //Find and input name
            IWebElement name = driver.FindElement(By.Id("Name"));
            name.SendKeys("Divya");
            Thread.Sleep(1000);

            //Find and input Username
            IWebElement uname = driver.FindElement(By.Id("Username"));
            uname.SendKeys("Du");
            Thread.Sleep(1000);

            //Find and input ContactDisplay/Email
            IWebElement contactname = driver.FindElement(By.Id("ContactDisplay"));
            contactname.SendKeys("abcd.12@yahoo.com");
            Thread.Sleep(1000);

            //Find and input Password
            IWebElement passwd = driver.FindElement(By.Id("Password"));
            passwd.SendKeys("Abc-1234");
            Thread.Sleep(1000);

            //Find and input Retype- Password
            IWebElement repasswd = driver.FindElement(By.Id("RetypePassword"));
            repasswd.SendKeys("Abc-1234");
            Thread.Sleep(1000);

            //Find check box and tick admin
            IWebElement admin = driver.FindElement(By.Id("IsAdmin"));
            admin.Click();
            Thread.Sleep(1000);

            //Find and input vechicle
            IWebElement vehicle = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            vehicle.SendKeys("567");

            //Function to click on save button
            homeObj.ClickOnSave(driver);

            //Find and click on Back to list button
            IWebElement back = driver.FindElement(By.XPath("//*[@id='container']/div/a")); 
            back.Click();

            //Calling Last Page function
            homeObj.LastPage(driver);

            //Check record is in list
            IWebElement lastrec = driver.FindElement(By.XPath(".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Console.WriteLine(lastrec.Text);
            if (lastrec.Text == "Divya")
            {
                Console.WriteLine("Record successfully save, Test Pass");
            }
            else
            {
                Console.WriteLine("Record not save, Test Fail");
            }
        }


        public void editEmployee(IWebDriver driver)
        {

        }

        public void deleteEmployee(IWebDriver driver)
        {

        }
    }
}
