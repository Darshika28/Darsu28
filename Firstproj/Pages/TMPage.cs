using OpenQA.Selenium;
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
            // Find and click on create button
            IWebElement createbtn = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createbtn.Click();
            Thread.Sleep(1000);

            // validation of Creating new time and Material Record

            //Find and click on type code dropdown list
            IWebElement dropdow = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            dropdow.Click();
            Thread.Sleep(1000);

            //Click on Time from dropdown list
            IWebElement time = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            time.Click();
            Thread.Sleep(1000);

            //Find and input code
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("9988");
            Thread.Sleep(1000);

            //Find and input description
            IWebElement des = driver.FindElement(By.Id("Description"));
            des.SendKeys("Is a QA");
            Thread.Sleep(1000);

            //Find and input Price per unit
            IWebElement priceperunit = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceperunit.Click();
            IWebElement priceunit = driver.FindElement(By.Id("Price"));
            priceunit.SendKeys("55");
            Thread.Sleep(1000);

            //Find and click save button
            IWebElement save = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            save.Click();
            Thread.Sleep(3000);

            //Find and click last page
            IWebElement lastpg = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            lastpg.Click();
            Thread.Sleep(1000);

            //Check record is in list
            IWebElement lastrec = driver.FindElement(By.XPath(".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Console.WriteLine(lastrec.Text);
            if (lastrec.Text == "9988")
            {
                Console.WriteLine("Record successfully save, Test Pass");
            }
            else
            {
                Console.WriteLine("Record not save, Test Fail");
            }
        }

        //Function to Edit existing TM
        public void editTM(IWebDriver driver)
        {
            // find and click edit button 
            IWebElement editbtn = driver.FindElement(By.XPath(".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editbtn.Click();

            //Find and input Code 
            IWebElement editcode = driver.FindElement(By.Id("Code"));
            editcode.Clear();
            editcode.SendKeys("7777");
            Thread.Sleep(1000);

            //Find and input Description
            IWebElement editdes = driver.FindElement(By.Id("Description"));
            editdes.Clear();
            editdes.SendKeys("Qaulity Assurance");
            Thread.Sleep(1000);

            // Find and input Price per unit
            IWebElement edipri = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            edipri.Click();
            IWebElement editprice = driver.FindElement(By.XPath("//*[@id='Price']"));
            editprice.Clear();
            edipri.Click();
            editprice.SendKeys("111");
            Thread.Sleep(1000);

            // Find and click save button after edit record
            IWebElement editsave = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            editsave.Click();
            Thread.Sleep(3000);

            // Find and click last page
            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            lastpage.Click();
            Thread.Sleep(1000);

            // Check record is in list
            IWebElement lastrecord = driver.FindElement(By.XPath(".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (lastrecord.Text == "7777")
            {
                Console.WriteLine(" Edited Record successfully save, Test Pass");
            }
            else
            {
                Console.WriteLine("Edited Record not save, Test Fail");
            }
        }

        //Function to Delete TM
        public void deleteTM(IWebDriver driver)
        {
            // Find and click on delete button
            driver.FindElement(By.XPath(".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);

            // Navigate to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();
           
            // Check record is in list
            IWebElement delrecord = driver.FindElement(By.XPath(".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (delrecord.Text == "7777")
            {
                Console.WriteLine(" Record not deleted, Test Failed");
            }
            else
            {
                Console.WriteLine("Record deleted successfully, Test Pass");
            }
        }
    }
}
