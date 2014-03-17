using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TeamCityDemo.Tests
{
    [TestClass]
    public class MyLogicTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PrintNTimes_WhenInputIsNull_ThrowArgumentNullException()
        {
            var logic = new MyLogic();

            string input = null;

            logic.PrintNTimes(input, 5);
        }

        [TestMethod]
        //[ExpectedException(typeof(InvalidOperationException))]
        public void PrintNTimes_WhenNArgumentIsNegative_ThrowInvalidOperationException()
        {
            var logic = new MyLogic();

            string input = "test_value";
            int n = -1;

            Assert.IsFalse(logic.PrintNTimes(input, n));

        }

        //[TestMethod]
        //public void PrintNTimes_WhenNArgumentIsNegative_ReturnFalse()
        //{
        //    var logic = new MyLogic();

        //    string input = "test_value";
        //    int n = -1;

        //    var result = logic.PrintNTimes(input, n);
        //    Assert.IsFalse(result);
        //}

        [TestMethod]
        public void PrintNTimes_WhenInputAndNAreValid_ReturnTrue()
        {
            var logic = new MyLogic();

            string input = "test_value";
            int n = 3;

            var result = logic.PrintNTimes(input, n);

            Assert.IsTrue(result);
        }
    }
}
