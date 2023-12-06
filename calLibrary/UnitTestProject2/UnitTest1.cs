using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit;
using Moq;
//using NUnit.Framework;
using calLibrary;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var teacherMock = new Mock<ITeacher>();
            teacherMock.Setup(t => t.GetName()).Returns("Dinesh");

            //Act
            var result = teacherMock.Object.GetName();

            //Assert using Assert.AreEqual
            Assert.AreEqual("Dinesh", result);

        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var subjectnameMock = new Mock<ISubject>();
            subjectnameMock.Setup(t => t.GetSubjectName()).Returns("English,Maths,Science");

            //Act
            var result = subjectnameMock.Object.GetSubjectName();

            //Assert using Assert.AreEqual
            Assert.AreEqual("English,Maths,Science", result);
        }
    }
}

