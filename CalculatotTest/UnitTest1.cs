using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatotTest
{
    [TestClass]
    public class UnitTest1
    {
        CalculatorUnderTest clc;
        [TestInitialize]
        public void Initialize()
        {
            clc = new CalculatorUnderTest();
        }
        [TestMethod]
        public void TestMethod1()
        {
            double result1 = clc.Divide(10, 2);
            Assert.AreEqual(5, result1);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double result2 = clc.Multiply(6, 2);
            Assert.AreEqual(12, result2);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double result3 = clc.Add(8, 5);
            Assert.AreEqual(13, result3);
        }
        [TestMethod]
        public void TestMethod4()
        {
            double result4 = clc.Minus(15, 3);
            Assert.AreEqual(12, result4);
        }
        [TestCleanup]
        public void CleanUpMethod()
        {
            clc = null;// or do something if necessary after test finishes
        }
    }
}
