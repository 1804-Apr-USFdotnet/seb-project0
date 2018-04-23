using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace TestPalindrome
{
    [TestClass]
    public class TestPalindrome
    {
        [TestMethod]
        public void TestCheck()
        {
            // Act
            bool expected1 = false;
            bool expected2 = false;
            bool expected3 = true;
            bool expected4 = true;

            // Arrange
            bool actual1 = PalindromeCheck.Check("New York!@");
            bool actual2 = PalindromeCheck.Check("Some other place");
            bool actual3 = PalindromeCheck.Check("never Odd, or Even.");
            bool actual4 = PalindromeCheck.Check("Race car!");

            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }
    }
}
