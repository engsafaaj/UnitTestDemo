using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitDemo;

namespace UnitTest.Tests
{
    [TestClass]
    class MathOpertorsTests
    {
        [TestMethod]
        public void Add_Test()
        {
            // Arrange
            MathOpertors mathOpertors = new MathOpertors();
            // Act & Expt
            int act = mathOpertors.Add(2, 4);
            int expt = 6;
            // Assert (Check)
            Assert.AreEqual(expt, act);
        }
    }
}
