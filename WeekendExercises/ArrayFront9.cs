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
        Given an array of ints, return true if one of the first 4 elements in the array is a 9. The array length may be less than 4.
        arrayFront9([1, 2, 9, 3, 4]) → true
        arrayFront9([1, 2, 3, 4, 9]) → false
        arrayFront9([1, 2, 3, 4, 5]) → false
        */
        public bool ArrayFront9(int[] nums)
        {
            bool result = false;
            if (nums.Length <= 4)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 9) result = true;
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    if (nums[i] == 9) result = true;
                }
            }

            return result;
        }
    }
}
