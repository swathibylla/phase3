using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;
using Moq;
using NUnit.Framework;
using calLibrary;
using NAssert = NUnit.Framework.Assert;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestTeacher()
        {
            var teacherMock = new Mock<Teacher>();
            teacherMock.Setup(t => t.GetName()).Returns("Dinesh");

            //Act 
            var result = teacherMock.Object.GetName();

            //Act
             NAssert.AreEqual("Dinesh", result);
            }
            // NAssert.AreEqual("Dinesh", result);
        }
    }

