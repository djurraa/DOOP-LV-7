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
        public void Palindrome_DammitImMad_ReturnsPalindrome(string input)
        {
            // Arrange

            Palindrome palindrome = new Palindrome();
            String expected = "Palindrome";

            // Act
            String actual = palindrome.IsPalindrome(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
