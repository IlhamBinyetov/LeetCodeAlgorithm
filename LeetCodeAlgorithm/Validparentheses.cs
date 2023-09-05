using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithm
{
    public class Validparentheses
    {
        public bool IsValid(string s)
        {
            if (s == null) return false;

            var k = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(') { k.Push(')'); continue; }
                if (c == '{') { k.Push('}'); continue; }
                if (c == '[') { k.Push(']'); continue; }
                if (k.Count == 0 || c != k.Pop()) return false;
            }
            return k.Count == 0;
        }
    }
}
