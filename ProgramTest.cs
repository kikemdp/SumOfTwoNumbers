using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProgramSum
{
    [TestClass]
    public class ProgramTest
    {

        [TestMethod]
        public void CallingSumReturnsTheExpectedResult()
        {
            uint[] array1 = { 1, 2, 3, 4 };
            uint[] array2 = { 9, 2, 3, 4, 5, 6 };

            ulong expectedResult = 655563;
            
            var result = Program.Sum(array1, array2);

            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void CallingSumWithTwoEmptyArraysReturnsZero()
        {
            uint[] array1 = Array.Empty<uint>();
            uint[] array2 = Array.Empty<uint>();

            ulong expectedResult = 0;
            var result = Program.Sum(array1, array2);

            Assert.AreEqual(result, expectedResult);
        }


        [TestMethod]
        public void CallingSumWithMoreThanOneDigitThrowsAnException()
        {
            uint[] array1 = { 11, 2, 3, 4 };
            uint[] array2 = { 9, 2, 3, 4, 5, 6 };

            Assert.ThrowsException<ArgumentException>(() => Program.Sum(array1, array2));
        }
    }
}
