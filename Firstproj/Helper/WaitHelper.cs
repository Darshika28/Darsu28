using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firstproj.Helper
{
    class WaitHelper
    {
        private static int seconds;

        //function for wait
        public static void WaitClickable(IWebDriver driver, string attribute, string value, int second)
        {
            try
            {
                if (attribute == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(value)));

                }
                if (attribute == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(value)));

                }
                if (attribute == "CSSSelector")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(value)));

                }
                
            }
            catch(Exception ex)
            {
                Assert.Fail("Unable to click web element", ex.Message);
            }
        }

        public static void WaitExists(IWebDriver driver, string attribute, string value, int second)
        {
            try
            {
                if(attribute == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(value)));
                }
                if(attribute == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(value)));
                }
                if (attribute == "CSSSelector")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(value)));
                } 
                  
            }
            catch(Exception ex)
            {
                Assert.Fail("Couldn't Find Element", ex.Message);
            }
        }
     
    }
}
