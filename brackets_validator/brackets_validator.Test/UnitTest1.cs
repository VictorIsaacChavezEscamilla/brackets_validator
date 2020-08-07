using NUnit.Framework;
using brackets_validator;

namespace brackets_validator.Test
{
    public class Tests
    {
        Validator validator;

        [SetUp]
        public void Setup()
        {
            validator = new Validator();
        }

        [TestCase]
        public void TestEmptyValue()
        {
            Assert.AreEqual(true, validator.IsBalanceBrackets(string.Empty), "Test Failed");
        }

        [TestCase("{()}")]
        [TestCase("{([])}")]
        [TestCase("[{()}]([[{()}]])")]
        public void TestBalaceBrackets(string value)
        {
            Assert.AreEqual(true, validator.IsBalanceBrackets(value), "Test Failed");
        }

        [TestCase("{()}(")]
        [TestCase("[{()}")]
        [TestCase("{()}]")]
        public void TestNotBalaceBrackets(string value)
        {
            Assert.AreEqual(false, validator.IsBalanceBrackets(value), "Test Failed");
        }
    }
}