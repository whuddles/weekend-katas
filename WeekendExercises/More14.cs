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
         Given an array of ints, return true if the number of 1's is greater than the number of 4's
         more14([1, 4, 1]) → true
         more14([1, 4, 1, 4]) → false
         more14([1, 1]) → true
         */
        public bool More14(int[] nums)
        {
            bool result = false;
            int count1 = 0;
            int count4 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count1++;
                }
                if (nums[i] == 4)
                {
                    count4++;
                }
            }
            if(count1 > count4)
            {
                result = true;
            }
            return result;
        }


    }
}
