﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an int array, return a new array with double the length where its last element is the same as the 
         original array, and all the other elements are 0. The original array will be length 1 or more. Note: by 
         default, a new int array contains all 0's.
         makeLast([4, 5, 6]) → [0, 0, 0, 0, 0, 6]
         makeLast([1, 2]) → [0, 0, 0, 2]
         makeLast([3]) → [0, 3]
         */
        public int[] MakeLast(int[] nums)
        {
            int last = nums[nums.Length-1];
            int[] result = new int[nums.Length * 2];

            
            for (int i = 0; i < result.Length-1; i++)
            {
                result[i] = 0;
            }
            result[result.Length - 1] = last;
            return result;
        }
    }
}
