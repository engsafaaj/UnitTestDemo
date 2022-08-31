using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace UnitDemo.Tests
{
    [TestClass]
    public class MathOpertorsTests
    {
        MathOpertors mathOpertors;

        [TestMethod]
        [Owner("Safaa Jassim")]
        [Description("This method retrun n1+n2 " +
            "when n1>0")]
        [Priority(1)]
        [Timeout(1)]
        [TestCategory("MathTest")]
        [TestInitialize]
        public void Add_n1_n2()
        {
            // Arrange
            MathOpertors mathOpertors = new MathOpertors();
            // Act and Expt
            int act = mathOpertors.Add(2, 4);
            int expt = 6;
            // Assert (Check)
            Assert.AreEqual(expt, act);
        }
        [TestMethod]
        [Owner("Safaa Jassim")]
        [Description("This method retrun n2 " +
            "when n1=0")]
        [Priority(1)]
        [TestCleanup]
        public void Add_n2()
        {
            // Arrange
            MathOpertors mathOpertors = new MathOpertors();
            // Act and Expt
            int act = mathOpertors.Add(0, 4);
            int expt = 4;
            // Assert (Check)
            //Assert.AreEqual(expt, act);
            act.Should().Be(expt);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Div_n2_0_returnException()
        {
            // Arrange
            MathOpertors mathOpertors = new MathOpertors();
            // Act and Expt
            var expt = mathOpertors.Div(4, 0);   
            
        }

    }
}
