using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1._15
{
    [TestClass]
    public class POMTest
    {
        [TestMethod]
        public void UsePOM()
        {
            using (var driver = new FirefoxDriver())
            {
                HomePOM home = new HomePOM(driver);
                home.goToPage();

                AboutUs about = home.goToAboutPage();
               // Assert.IsTrue(driver.PageSource.Contains("About Simplilearn"));

            }
        }
    }
}

   
