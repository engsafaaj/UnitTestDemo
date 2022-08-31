using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitDemo;
using Moq;

namespace UnitDemo.Tests
{
    [TestClass]
    public class StudnetTests
    {
        private readonly IDataHelper<Students> dataHelper;
        public StudnetTests()
        {
            dataHelper = new StudentEntity();
        }
        [TestMethod]
        public void MyTestMethod()
        {
            List<Students> ListOfStudent = new List<Students>();
            Students students1 = new Students
            {
                FisrtName = "Safaa",
                Age = 24,
              
            };

            ListOfStudent.Add(students1);

            CollectionAssert.AllItemsAreInstancesOfType(ListOfStudent, typeof(Students));
        }
        [TestMethod]
        public void AddReturn1()
        {
            // Arrange
            List<Students> ListOfStudents = new List<Students>()
            {
                new Students(){FisrtName="Safaa",Age=24},
                new Students(){FisrtName="Ali",Age=29,Id=2},
                new Students(){FisrtName="Ahmed",Age=18,Id=3},
            };

         
            // Act
            int act =dataHelper.Add(ListOfStudents[0]) ;
            int expt = 1;
            Assert.AreEqual(expt, act);

        }
    }
}
