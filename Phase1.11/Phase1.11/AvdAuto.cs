using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;

namespace Phase1._11
{
    [TestClass]
    public class AvdAuto
    {
        [TestMethod]
        public void IFrame()
        {
            using (var driver = new FirefoxDriver())
            {

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("file:C:\\Users\\swath\\Documents\\WebConnectivity\\Phase1.11\\Phase1.11\\IFrametest.html");

                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(
                     d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

                //var iframes = driver.FindElementsByTagName("Iframe");
                //Assert.IsTrue(Iframes.Count == 2);

                driver.SwitchTo().Frame(0);
                var frameTitle = driver.PageSource.Contains("Corporate Training");
                Assert.IsNotNull(frameTitle);
            }
        }

        [TestMethod]
        public void ScreenShot()
        {
            using (var driver = new FirefoxDriver())
            {

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.simplilearn.com");

                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(
                     d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("d:/test.png", ScreenshotImageFormat.Png); 
            }
        }
    }

}

