using FIZZ;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BUZZ_Test
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestPrinting100Numbers()
        {
            var buzzzzz = new BUZZZZZ();
            buzzzzz.PrintNumbers();
        }


        [TestMethod]
        public void TestPrintBuzzWhenMultipleOf3()
        {
            var buzzzzz = new BUZZZZZ();
            string output = buzzzzz.GetOutput(3);

            Assert.AreEqual(output, "FizzBuzz");
         }

        [TestMethod]
        public void TestPrintBuzzWhenMultipleOf5()
        {
            var buzzzzz = new BUZZZZZ();
            string output = buzzzzz.GetOutput(5);

            Assert.AreEqual(output, "Buzz");
        }

        [TestMethod]
        public void TestPrintNumber()
        {
            var buzzzzz = new BUZZZZZ();
            string output = buzzzzz.GetOutput(2);

            Assert.AreEqual(output, "2");
        }
    }
}

    

