using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1_1
{
    [TestClass]
    public class UnitTest1_1
    {
        public object Validator { get; private set; }

        [TestMethod]
        public void TestMethod1_1()
        {
            // Arrange
            String hexBlack = "#000000";

            Boolean expectedReturnBlack = false;

            Boolean actualReturnBlack = Validator.IsHexColourCode(hexBlack);

            Assert.AreEqual(expectedReturnBlack, actualReturnBlack, "failed ...");

        }
    }
}
