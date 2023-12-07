using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1._15
{
    [TestClass]
    public class AboutUs
    {
        private IWebDriver driver;

        public AboutUs(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);
        }


        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://www.simplilearn.com/about-us");
        }


    }
}
