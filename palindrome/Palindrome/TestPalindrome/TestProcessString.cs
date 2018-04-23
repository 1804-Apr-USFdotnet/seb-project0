using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace TestPalindrome
{
    [TestClass]
    public class TestProcessString
    {
        [TestMethod]
        public void TestRemoveSpecialCharacters()
        {
            // Act
            string expected1 = "NewYork";
            string expected2 = "Someotherplace";
            string expected3 = "neverOddorEven";

            // Arrange
            string actual1 = ProcessString.RemoveSpecialCharacters("..!!New   York;[]");
            string actual2 = ProcessString.RemoveSpecialCharacters("Some, !other ..place");
            string actual3 = ProcessString.RemoveSpecialCharacters("never Odd, or Even.");

            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);

        }

        [TestMethod]
        public void TestLowerCase()
        {
            // Act
            string expected1 = "newyork";
            string expected2 = "someotherplace";
            string expected3 = "neveroddoreven";

            // Arrange
            string actual1 = ProcessString.LowerCase("NewYork");
            string actual2 = ProcessString.LowerCase("Someotherplace");
            string actual3 = ProcessString.LowerCase("neverOddorEven");

            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod]
        public void TestCheckPalindrome()
        {
            // Act
            bool expected1 = false;
            bool expected2 = false;
            bool expected3 = true;

            // Arrange
            bool actual1 = ProcessString.CheckPalindrome("newyork");
            bool actual2 = ProcessString.CheckPalindrome("someotherplace");
            bool actual3 = ProcessString.CheckPalindrome("neveroddoreven");

            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
    }
}
