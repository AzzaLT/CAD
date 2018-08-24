using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
 // Arrange.
 int lower = 100;
 int upper = 200;
 int withinRange = 123;
 int belowRange = 98;
 int aboveRange = 321;
 int belowLowerLimit = 99;
 int equalLowerLimit = 100;
 int aboveLowerLimit = 101;
 int belowUpperLimit = 199;
 int equalUpperLimit = 200;
 int aboveUpperLimit = 201;
 Boolean expectedReturnWithin = true;
 Boolean expectedReturnBelow = false;
 Boolean expectedReturnAbove = false;
 Boolean expectedReturnBelowLower = false;
 Boolean expectedReturnEqualLower = true;
 Boolean expectedReturnAboveLower = true;
 Boolean expectedReturnBelowUpper = true;
 Boolean expectedReturnEqualUpper = true;
 Boolean expectedReturnAboveUpper = false;
 // Act.
 Boolean actualReturnWithin = Validator.TryRange(withinRange, lower, upper);
 Boolean actualReturnBelow = Validator.TryRange(belowRange, lower, upper);
 Boolean actualReturnAbove = Validator.TryRange(aboveRange, lower, upper); 
 Boolean actualReturnBelowLower = Validator.TryRange(belowLowerLimit, lower, upper);
 Boolean actualReturnEqualLower = Validator.TryRange(equalLowerLimit, lower, upper);
 Boolean actualReturnAboveLower = Validator.TryRange(aboveLowerLimit, lower, upper);
 Boolean actualReturnBelowUpper = Validator.TryRange(belowUpperLimit, lower, upper);
 Boolean actualReturnEqualUpper = Validator.TryRange(equalUpperLimit, lower, upper);
 Boolean actualReturnAboveUpper = Validator.TryRange(aboveUpperLimit, lower, upper);
 // Assert.
 Assert.AreEqual(expectedReturnWithin, actualReturnWithin, "failed ...");
 Assert.AreEqual(expectedReturnBelow, actualReturnBelow, "failed ...");
 Assert.AreEqual(expectedReturnAbove, actualReturnAbove, "failed ...");
 Assert.AreEqual(expectedReturnBelowLower, actualReturnBelowLower, "failed ...");
 Assert.AreEqual(expectedReturnEqualLower, actualReturnEqualLower, "failed ...");
 Assert.AreEqual(expectedReturnAboveLower, actualReturnAboveLower, "failed ...");
 Assert.AreEqual(expectedReturnBelowUpper, actualReturnBelowUpper, "failed ...");
 Assert.AreEqual(expectedReturnEqualUpper, actualReturnEqualUpper, "failed ...");
 Assert.AreEqual(expectedReturnAboveUpper, actualReturnAboveUpper, "failed ...");
 }


        }
    }
}
