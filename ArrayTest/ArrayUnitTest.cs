using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayTest
{
    [TestClass]
    public class ArrayUnitTest
    {
        [TestMethod]
        public void TestArraySum()
        {
            // Create an array of integers
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Create an instance of the ArraySum class
            ArraySum arraySum = new ArraySum();

            // Call the Sum method and check the result
            int result = arraySum.Sum(numbers);
            Assert.AreEqual(15, result);
        }
    }
}
