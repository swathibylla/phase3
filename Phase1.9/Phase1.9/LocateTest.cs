using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace Phase1._9
{
    [TestClass]
    public class LocateTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var driver = new FirefoxDriver())
            {

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.simplilearn.com/");

                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(
                     d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

              //  var searchBox = driver.FindElementById("header_srch");
               // Assert.IsNotNull(searchBox);
               // searchBox.SendKeys("ASP.NET");
               // var searchButton = driver.FindElementByClassName("login");
                //searchButton.Click();

                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(
                   d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));


                var pageTitle = driver.PageSource.Contains("Learning on Simplilearn");
                Assert.IsNotNull(pageTitle);

                //var footerText = driver.FindElementByXPath("//footer[@class='footer']");
                //Assert.IsNotNull(footerText);
            }
        }
    }

}
  
