using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrozzleApplication;
namespace UnitTest1_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            // Arrange.
            String hexBlack = "#000000";
            String hexRedish = "#AA0000";
            String hexWhite = "#FFFFFF";
            String invalid1 = "000000";
            String invalid2 = "#00000X";
            String invalid3 = "#!@#$%^";
            Boolean expectedReturnBlack = true;
            Boolean expectedReturnRedish = true;
            Boolean expectedReturnWhite = true;
            Boolean expectedReturnInvalid1 = false;
            Boolean expectedReturnInvalid2 = false;
            Boolean expectedReturnInvalid3 = false;
            // Act.
            Boolean actualReturnBlack = Validator.IsHexColourCode(hexBlack);
            Boolean actualReturnRedish = Validator.IsHexColourCode(hexRedish);
            Boolean actualReturnWhite = Validator.IsHexColourCode(hexWhite);
            Boolean actualReturnInvalid1 = Validator.IsHexColourCode(invalid1);
            Boolean actualReturnInvalid2 = Validator.IsHexColourCode(invalid2);
            Boolean actualReturnInvalid3 = Validator.IsHexColourCode(invalid3);
            // Assert.
            Assert.AreEqual(expectedReturnBlack, actualReturnBlack, "failed ...");
            Assert.AreEqual(expectedReturnRedish, actualReturnRedish, "failed ...");
            Assert.AreEqual(expectedReturnWhite, actualReturnWhite, "failed ...");
            Assert.AreEqual(expectedReturnInvalid1, actualReturnInvalid1, "failed ...");
            Assert.AreEqual(expectedReturnInvalid2, actualReturnInvalid2, "failed ...");
            Assert.AreEqual(expectedReturnInvalid3, actualReturnInvalid3, "failed ...");


        }
    }
}
