using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Palindrom.Test
{
    [TestFixture]
    public class PalindromeTest
    {
        [TestCase("Dammit I'm mad")]
        [TestCase("Ana voli Milovana")]
        [TestCase("Taco cat")]
        [TestCase("11211")]
        public void Palindrome_inputIsPalindrome_ReturnsPalindrome(string input)
        {
            // Arrange
            Palindrome palindrome = new Palindrome();
            String expected = "Palindrome";
            // Act
            String actual = palindrome.IsPalindrome(input);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Dario")]
        [TestCase("Nina Kraviz")]
        [TestCase("Campus")]
        public void Palindrome_input_NOTPalindrome_Returns_NotPalindrome(string input)
        {
            // Arrange
            Palindrome palindrome = new Palindrome();
            String expected = "Not palindrome";
            // Act
            String actual = palindrome.IsPalindrome(input);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Campus")]
        public void Palindrome_input_EmptyString_Returns_NotPalindrome(string input)
        {
            // Arrange
            Palindrome palindrome = new Palindrome();
            String expected = "Not palindrome";
            // Act
            String actual = palindrome.IsPalindrome(input);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
