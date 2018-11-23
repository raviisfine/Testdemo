using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
// using OpenQA.Selenium.Support.UI;
namespace Testing
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(@"D:\Softwares\chromedriver_win32\");
            driver.Navigate().GoToUrl("https://gttpdemo.azurewebsites.net/");
            driver.Manage().Window.Maximize();
            driver.Close();
            
               
            
            
            
            
            
            // driver.FindElement(By.XPath("//li[@class='auth auth-container']/span[@class='sign-in']/a[@class='auth-link']")).Click();
            // driver.FindElement(By.XPath("//input[@id='i0116']")).SendKeys("raviisfine@outlook.com");
            // driver.FindElement(By.XPath("//input[@id='idSIButton9']")).Click();
            

            // driver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(45);
            // driver.FindElement(By.XPath("//input[@id='i0118']")).SendKeys("Health0!");
            // driver.FindElement(By.XPath("//input[@id='idSIButton9']")).Click();
            // driver.Close();  
            // driver.FindElement(By.Id("i0118")).SendKeys("Health0!");    
        }
    }
}
