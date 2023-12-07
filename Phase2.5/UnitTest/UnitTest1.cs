using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Warnings()
        {
            int total = 100, marks1 = 60, marks2 = 75;
            string name = null;

            Warn.If(marks1 > 100);
            Warn.If(name == null);

            Warn.Unless(marks1 + marks2 < 200);

            Assert.Warn("This is a warning message");
        }
    }
}



       
