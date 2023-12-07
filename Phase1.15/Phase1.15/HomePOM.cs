using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1._15
{
    
      class HomePOM
    {
        private IWebDriver driver;

        public HomePOM(IWebDriver driver)
        {
            this.driver = driver;
           // PageFactory.InitElements(driver, this);
        }

        //[FindsBy(How = How.LinkText, Using = "About us")]
        //private IWebElement about;

        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://www.simplilearn.com/");
        }

        public AboutUs goToAboutPage()
        {
            //about.Click();
            return new AboutUs(driver);
        }


    }
}
