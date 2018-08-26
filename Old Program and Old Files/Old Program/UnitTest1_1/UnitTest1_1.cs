using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrozzleApplication;
namespace UnitTest1_1
{
    [TestClass]
    public class UnitTest1_1
    {
        [TestMethod]
        public void TestMethod1_1()
        {

            // Arrange.
            String hexBlack = "#000000";
 
            String invalid1 = "#000000";
  
            Boolean expectedReturnBlack = true;
    
            Boolean expectedReturnInvalid1 = true;
        
            // Act.
            Boolean actualReturnBlack = Validator.IsBoolean(hexBlack);

            Boolean actualReturnInvalid1 = Validator.IsBoolean(invalid1);
  
            // Assert.
            Assert.AreEqual(expectedReturnBlack, actualReturnBlack, "failed ...");
         
            Assert.AreEqual(expectedReturnInvalid1, actualReturnInvalid1, "failed ...");
      


        }
    }
}
