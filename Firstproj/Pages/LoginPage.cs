using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firstproj.Pages
{
    class LoginPage
    {
        // Input and login in Portal up
        public void loginStep(IWebDriver driver)
        {
            // Launch Portal
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            // Maximize the browser
            driver.Manage().Window.Maximize();

            // Find username textbox and input username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            // Find password textbox and input password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            // Find login buttion and click
            IWebElement loginbtn = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginbtn.Click();

            //Find hello hari hyperlink
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in Successfully");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }

        }
    }
}
