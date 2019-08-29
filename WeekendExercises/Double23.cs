using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {


        /*
         Given an int array, return true if the array contains 2 twice, or 3 twice. The array will be length 0, 1, or 2.
         double23([2, 2]) → true
         double23([3, 3]) → true
         double23([2, 3]) → false
         */
        public bool Double23(int[] nums)
        {
            int count2 = 0;
            int count3 = 0;
            foreach (int item in nums)
            {
                if (item == 2) count2++;
                if (item == 3) count3++;
            }
            if (count2 > 1 || count3 > 1) return true;
            else return false;
        }
    }
}
