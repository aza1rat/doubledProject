using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassTest;

namespace UnitTestClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int a = 3;
            int b = 4;
            int expected = 7;
            //Act
            ClassNew classNew = new ClassNew();
            int actual = classNew.Solve(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
