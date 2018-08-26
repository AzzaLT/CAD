using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrozzleApplication;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Boolean a = true;
            string aBoolean = "true";
            string bBoolean = "false";
            string cBoolean = "yes";
            string dBoolean = "no";
            string eBoolean = "dhfjvk";

            Boolean aExpectedReturn = true;
            Boolean bExpectedReturn = true;
            Boolean cExpectedReturn = false;
            Boolean dExpectedReturn = false;
            Boolean eExpectedReturn = false;

            Boolean actual = Validator.IsBoolean(aBoolean, out a);
            Assert.AreEqual(aExpectedReturn, actual, "IsBoolean test 1 fail");

            actual = Validator.IsBoolean(bBoolean, out a);
            Assert.AreEqual(bExpectedReturn, actual, "IsBoolean test 2 fail");

            actual = Validator.IsBoolean(cBoolean, out a);
            Assert.AreEqual(cExpectedReturn, actual, "IsBoolean test 3 fail");

            actual = Validator.IsBoolean(dBoolean, out a);
            Assert.AreEqual(dExpectedReturn, actual, "IsBoolean test 4 fail");

            actual = Validator.IsBoolean(eBoolean, out a);
            Assert.AreEqual(eExpectedReturn, actual, "IsBoolean test 5 fail");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Int32 a = 1;
            string aInt32 = "1";
            string bInt32 = "1.00";
            string cInt32 = "A";

            Boolean aExpectedReturn = true;
            Boolean bExpectedReturn = false;
            Boolean cExpectedReturn = false;

            Boolean actual = Validator.IsInt32(aInt32, out a);
            Assert.AreEqual(aExpectedReturn, actual, "IsInt32 test 1 failed.");

            actual = Validator.IsInt32(bInt32, out a);
            Assert.AreEqual(bExpectedReturn, actual, "IsInt32 test 2 failed.");

            actual = Validator.IsInt32(cInt32, out a);
            Assert.AreEqual(cExpectedReturn, actual, "IsInt32 test 3 failed.");
        }

        [TestMethod]
        public void TestMethod3()
        {
            string aHexColour = "#FFA500";
            string bHexColour = "000000";
            string cHexColour = "!@$%^&";

            Boolean aExpectedReturn = true;
            Boolean bExpectedReturn = false;
            Boolean cExpectedReturn = false;

            Boolean actual = Validator.IsHexColourCode(aHexColour);
            Assert.AreEqual(aExpectedReturn, actual, "IsHexColourCode test 1 failed.");

            actual = Validator.IsHexColourCode(bHexColour);
            Assert.AreEqual(bExpectedReturn, actual, "IsHexColourCode test 2 failed.");

            actual = Validator.IsHexColourCode(cHexColour);
            Assert.AreEqual(cExpectedReturn, actual, "IsHexColourCode test 3 failed.");
        }

        [TestMethod]
        public void TestMethod4()
        {
            KeyValue a;
            string aOriginalKeyValue = "ROW=14";
            string aKeyPattern = "ROW";

            string bOriginalKeyValue = "ROW=14";
            string bKeyPattern = "roW";

            string cOriginalKeyValue = "ROW14";
            string cKeyPattern = "ROW";

            string dOriginalKeyValue = "ROW=14";
            string dKeyPattern = "ideibe";

            Boolean aExpectedReturn = true;
            Boolean bExpectedReturn = false;
            Boolean cExpectedReturn = false;
            Boolean dExpectedReturn = false;

            Boolean actual = KeyValue.TryParse(aOriginalKeyValue, aKeyPattern, out a);
            Assert.AreEqual(aExpectedReturn, actual, "KeyValue.TryParse test 1 failed.");

            actual = KeyValue.TryParse(bOriginalKeyValue, bKeyPattern, out a);
            Assert.AreEqual(bExpectedReturn, actual, "KeyValue.TryParse test 2 failed.");

            actual = KeyValue.TryParse(cOriginalKeyValue, cKeyPattern, out a);
            Assert.AreEqual(cExpectedReturn, actual, "KeyValue.TryParse test 3 failed.");

            actual = KeyValue.TryParse(dOriginalKeyValue, dKeyPattern, out a);
            Assert.AreEqual(dExpectedReturn, actual, "KeyValue.TryParse test 4 failed.");
        }

        [TestMethod]
        public void TestMethod5()
        {

        }
    }
}
