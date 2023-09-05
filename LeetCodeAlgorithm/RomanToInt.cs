using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithm
{
    public  class RomanToInt
    {
        //IV
        public int RomanToInteger(string s)
        {
            int sum = 0;
            Dictionary<char, int> romanNumbersDict = new ()
            {
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000}
            };

            for (int i = 0; i < s.Length; i++)
            {
               
                char currentRomanChar = s[i];
                romanNumbersDict.TryGetValue(currentRomanChar, out int num);
                if(i+1 < s.Length && romanNumbersDict[s[i + 1]] > romanNumbersDict[currentRomanChar])
                {
                    sum -= num;
                }
                else
                {
                    sum += num;
                }
            }


            return sum;
        }
    }
}
