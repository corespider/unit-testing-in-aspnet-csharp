using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Demo.App.Models;
namespace Demo.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator _cal = new Calculator();

            // addition
            Assert.AreEqual(_cal.add(10, 20),30);

            // substraction
            Assert.AreEqual(_cal.sub(20, 20), 0);

            // multiplication
            Assert.AreEqual(_cal.mul(10, 20), 200);

            // division
            Assert.AreEqual(_cal.div(20, 20), 0);
        }
    }
}
