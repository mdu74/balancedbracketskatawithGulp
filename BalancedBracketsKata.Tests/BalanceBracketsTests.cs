using CalculatorKata;
using NUnit.Framework;

namespace BalancedBracketsKata.Tests
{
    [TestFixture]
    public class BalanceBracketsTest
    {
        [Test]
        public void CheckForBalancedBrackets_GivenEmptyString_ShouldReturnOK()
        {
            //---------------Set up test pack-------------------
            var balanceBrackets = CreateBalanceBrackets();
            var input = string.Empty;
            var expected = "OK";
            //---------------Execute Test ----------------------
            var result = balanceBrackets.CheckForBalancedBrackets(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckForBalancedBrackets_GivenOpenBracket_ShouldReturnFAIL()
        {
            //---------------Set up test pack-------------------
            var balanceBrackets = CreateBalanceBrackets();
            var input = "[";
            var expected = "FAIL";
            //---------------Execute Test ----------------------
            var result = balanceBrackets.CheckForBalancedBrackets(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckForBalancedBrackets_GivenClosedBracket_ShouldReturnFAIL()
        {
            //---------------Set up test pack-------------------
            var balanceBrackets = CreateBalanceBrackets();
            var input = "]";
            var expected = "FAIL";
            //---------------Execute Test ----------------------
            var result = balanceBrackets.CheckForBalancedBrackets(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckForBalancedBrackets_GivenBalancedBrackets_ShouldReturnOK()
        {
            //---------------Set up test pack-------------------
            var balanceBrackets = CreateBalanceBrackets();
            var input = "[]";
            var expected = "OK";
            //---------------Execute Test ----------------------
            var result = balanceBrackets.CheckForBalancedBrackets(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckForBalancedBrackets_GivenUnbalancedPaired_ShouldReturnFAIL()
        {
            //---------------Set up test pack-------------------
            var balanceBrackets = CreateBalanceBrackets();
            var input = "][";
            var expected = "FAIL";
            //---------------Execute Test ----------------------
            var result = balanceBrackets.CheckForBalancedBrackets(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckForBalancedBrackets_GivenBalancedPaired_ShouldReturnOK()
        {
            //---------------Set up test pack-------------------
            var balanceBrackets = CreateBalanceBrackets();
            var input = "[][]";
            var expected = "OK";
            //---------------Execute Test ----------------------
            var result = balanceBrackets.CheckForBalancedBrackets(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckForBalancedBrackets_GivenNestedBalancedPaired_ShouldReturnOK()
        {
            //---------------Set up test pack-------------------
            var balanceBrackets = CreateBalanceBrackets();
            var input = "[[]]";
            var expected = "OK";
            //---------------Execute Test ----------------------
            var result = balanceBrackets.CheckForBalancedBrackets(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        private static BalanceBrackets CreateBalanceBrackets()
        {
            return new BalanceBrackets();
        }
    }
}
