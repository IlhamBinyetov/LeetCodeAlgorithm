using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithm
{
    public class LongestCommonPrefix
    {
        //{"ab", "a"} 
        public string Prefix(string[] strs)
        {
            if(strs.Length == 1) return strs[0];

            string prefixString = strs[0];

            if (strs == null || strs.Length == 0) return "";


            for (int i = 1; i < strs.Length; i++)
            {
                string currentString = strs[i];
                int j = 0;
                while (j < prefixString.Length && j < currentString.Length && prefixString[j] == currentString[j])
                {
                    j++;
                }
                prefixString = prefixString.Substring(0, j);

                if (string.IsNullOrEmpty(prefixString))
                    break;
            }

            return prefixString;
        }
    }
}
