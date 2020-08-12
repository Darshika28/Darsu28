using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Firstproj.Pages
{
    class HomePage
    {
        //Navigate to Portal up New TM record Page
        public void NavigateToTM(IWebDriver driver)
        {
            // Find and Click on administration 
            IWebElement admindrop = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            admindrop.Click();
            Thread.Sleep(1000);

            // Find and click on Time & Material page
            IWebElement matdrop = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            matdrop.Click();
            Thread.Sleep(1000);
                      
        }

        //Navigate to Employee Page
        public void NavigateToEmployee(IWebDriver driver)
        {
            // Find and Click on administration 
            IWebElement admindrop = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            admindrop.Click();
            Thread.Sleep(1000);

            // Find and click on Employee page
            IWebElement matdrop = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            matdrop.Click();
            Thread.Sleep(1000);
        }

    }
}
