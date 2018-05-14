using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    public class Palindrome
    {

        public String IsPalindrome(string input)
        {
            int min = 0;
            int max = input.Length - 1;

            while (true)
            {
                if (min > max)
                    return "Palindrome";

                char a = input[min];
                char b = input[max];

                while (!char.IsLetterOrDigit(a))
                {
                    min++;
                    if (min > max)
                        return "Palindrome";
                    a = input[min];
                }

                while (!char.IsLetterOrDigit(b))
                {
                    max--;
                    if (min > max)
                        return "Palindrome";
                    b = input[max];
                }
                if (char.ToLower(a) != char.ToLower(b))
                    return "Not palindrome";
                min++;
                max--;
            }
        }
    }
}
