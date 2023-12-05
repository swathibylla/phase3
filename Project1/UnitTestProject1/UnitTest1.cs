using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using NUnit;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var teacherMock = new Mock<Teacher>();
            teacherMock.Setup(t => t.GetName()).Returns("Kavya");
            //Act
            var result = teacherMock.Object.GetName();

            //Assert
            Assert.AreEqual("kavya", result);
        }
    }
}
