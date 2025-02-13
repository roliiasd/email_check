using System;
using Email;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Email_Tests
{
    [TestClass]
    public class Email_Validator_Tests
    {
        [TestMethod]
        public void IsValidEmail_ReturnsTrue()
        {
            var validator = new Email_Validator();

            bool result = validator.IsValidEmail("test@test.com");

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailWithoutAtSymbol_ReturnsFalse()
        {
            var validator = new Email_Validator();

            bool result = validator.IsValidEmail("testtest.com");

            Assert.IsFalse(result);
        }
    }
}
