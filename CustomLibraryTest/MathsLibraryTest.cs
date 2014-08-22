using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomLibrary;

namespace CustomLibraryTest
{
    [TestClass]
    public class MathsLibraryTest
    {
        private MathsLibrary math;

        [TestInitialize]
        public void Initialize()
        {
            math = new MathsLibrary();
        }

        [TestMethod]
        [TestCategory("CDVM")]
        public void Add_Test()
        {
            Assert.AreEqual(7, math.Add(5, 2));
        }

        [TestMethod]
        [TestCategory("CDVM")]
        public void Subtract_Test()
        {
            Assert.AreEqual(3, math.Subtract(5, 2));
        }

        [TestMethod]
        [TestCategory("Gautam")]
        public void Multiply_Test()
        {
            Assert.AreEqual(10, math.Multiply(5, 2));
        }

    }
}
