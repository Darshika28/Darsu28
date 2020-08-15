using Firstproj.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Firstproj.Pages
{
    class TMPage
    {

        // Function to create ne TM
        public void createTM(IWebDriver driver)
        {
            WaitHelper.WaitClickable(driver, "XPath", "//*[@id='container']/p/a", 5);

            // Init and define HomePAge object
            HomePage homeObj = new HomePage();

            //Function of Click on create button
            homeObj.ClickOnCreate(driver);

            // validation of Creating new time and Material Record

            WaitHelper.WaitClickable(driver, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]", 5);

            //Find and click on type code dropdown list
            IWebElement dropdow = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            dropdow.Click();

            //Click on Time from dropdown list
            IWebElement time = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            time.Click();

            WaitHelper.WaitExists(driver, "Id", "Code", 5);

            //Find and input code
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("9988");

            //Find and input description
            IWebElement des = driver.FindElement(By.Id("Description"));
            des.SendKeys("Is a QA");

            //Find and input Price per unit
            IWebElement priceperunit = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceperunit.Click();
            IWebElement priceunit = driver.FindElement(By.Id("Price"));
            priceunit.SendKeys("55");

            //Function to click on save button
            homeObj.ClickOnSave(driver);

         //   WaitHelper.WaitExists(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]", 5);
            WaitHelper.WaitClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]", 5);
            

           // Thread.Sleep(3000);
            //Calling Last Page function
            homeObj.LastPage(driver);

           // driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click(); ;
            
          //  WaitHelper.WaitExists(driver, "XPath", ".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 5);
            WaitHelper.WaitClickable(driver, "XPath", ".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 5);


            //Check record is in list
            IWebElement lastrec = driver.FindElement(By.XPath(".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Console.WriteLine(lastrec.Text);

            Assert.That(lastrec.Text, Is.EqualTo("9988"));
        }

        //Function to Edit existing TM
        public void editTM(IWebDriver driver)
        {
            HomePage homeObj = new HomePage();

            //Calling Last Page function
            homeObj.LastPage(driver);

            // find and click edit button 
            IWebElement editbtn = driver.FindElement(By.XPath(".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editbtn.Click();

            try
            {
                //Find and input Code 
                IWebElement editcode = driver.FindElement(By.Id("Code"));
                editcode.Clear();
                editcode.SendKeys("7777");
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Edit Page did not launch", ex.Message);
            }

            //Find and input Description
            IWebElement editdes = driver.FindElement(By.Id("Description"));
            editdes.Clear();
            editdes.SendKeys("Qaulity Assurance");

            // Find and input Price per unit
            IWebElement edipri = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            edipri.Click();
            IWebElement editprice = driver.FindElement(By.XPath("//*[@id='Price']"));
            editprice.Clear();
            edipri.Click();
            editprice.SendKeys("111");

            //Function to click on save button
            homeObj.ClickOnSave(driver);

            WaitHelper.WaitClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]", 5);

            Thread.Sleep(3000);
            try
            {
                //Calling Last Page function
                homeObj.LastPage(driver);
            }
            catch (Exception ex)
            {
                Assert.Fail("Edited Record did not save", ex.Message);
            }

            WaitHelper.WaitExists(driver, "XPath", ".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 5);

            // Check record is in list
            IWebElement lastrecord = driver.FindElement(By.XPath(".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(lastrecord.Text, Is.EqualTo("7777"));
        }

        //Function to Delete TM
        public void deleteTM(IWebDriver driver)
        {
            HomePage homeObj = new HomePage();
            Thread.Sleep(3000);

            //Calling Last Page function
            homeObj.LastPage(driver);

            // Find and click on delete button
            driver.FindElement(By.XPath(".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();
            driver.SwitchTo().Alert().Accept();

            WaitHelper.WaitClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]", 5);

            //Calling Last Page function
            homeObj.LastPage(driver);

            WaitHelper.WaitExists(driver, "XPath", ".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 5);

            // Check record is in list
            IWebElement delrecord = driver.FindElement(By.XPath(".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(delrecord.Text, Is.EqualTo("7777"));
        }
    }
}
