using System;
using factorial_with_test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Factorial_2()
        {
            Factorial factorial = new Factorial();
            int number = 2;
            int numberExpected = 2;
            int numberActual = factorial.getFactorialNumber(number);
            Assert.AreEqual(numberExpected, numberActual);
        }

        [TestMethod]
        public void Factorial_3()
        {
            Factorial factorial = new Factorial();
            int number = 3;
            int numberExpected = 6;
            int numberActual = factorial.getFactorialNumber(number);
            Assert.AreEqual(numberExpected, numberActual);
        }
    }
}
