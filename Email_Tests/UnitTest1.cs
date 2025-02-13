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

        [TestMethod]
        public void EmailWithMultipleAtSymbols_ReturnsFalse()
        {
            var validator = new Email_Validator();

            bool result = validator.IsValidEmail("test@@test.com");

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void EmailWithoutDomain_ReturnsFalse()
        {
            var validator = new Email_Validator();

            bool result = validator.IsValidEmail("test@");

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void EmailWithoutLocalPart_ReturnsFalse()
        {
            var validator = new Email_Validator();

            bool result = validator.IsValidEmail("@abrakadabra.com");

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void EmailWithoutTLD_ReturnsFalse()
        {
            var validator = new Email_Validator();

            bool result = validator.IsValidEmail("ikszde@abrakadabra");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EmptyEmail_ReturnsFalse()
        {
            var validator = new Email_Validator();

            bool result = validator.IsValidEmail("");

            Assert.IsFalse(result);
        }
    }
}
