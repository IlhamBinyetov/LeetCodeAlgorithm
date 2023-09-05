using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithm
{
    public  class Palindrome
    {
        public bool IsPalindrome(int number)
        {

            var x = number.ToString().ToCharArray();
            Array.Reverse(x);
            return number.ToString() == new string(x);

           
        } 
    }
}
