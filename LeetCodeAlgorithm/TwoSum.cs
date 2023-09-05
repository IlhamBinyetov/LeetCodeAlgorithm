using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithm
{
    public  class TwoSum
    {
        //int[] nums = { 1, 2, 3, 4, 5, };
       //target = 3;
        public int[] ShowSum(int[] nums, int target)
        {
           

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        return new int[] {i,j };
                    }
                }
            }
            return null;
        }
    }
}
