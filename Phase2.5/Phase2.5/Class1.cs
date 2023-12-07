using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using Moq;


namespace Phase2._5
{
  
        [TestFixture]
        public class Class1
        {

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
