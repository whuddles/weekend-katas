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
        Given three ints, a b c, one of them is small, one is medium and one is large. Return true if the three values are evenly 
        spaced, so the difference between small and medium is the same as the difference between medium and large.
        evenlySpaced(2, 4, 6) → true
        evenlySpaced(4, 6, 2) → true
        evenlySpaced(4, 6, 3) → false
        */
        public bool EvenlySpaced(int a, int b, int c)
        {
            int[] nums = { a, b, c };
            int large = 0;
            int small = int.MaxValue;
            int med = 0;            

            for (int i = 0; i < nums.Length; i++)
            {                
                if (nums[i] > large) large = nums[i];
                if (nums[i] < small) small = nums[i];                
            }
            foreach (int item in nums)
            {
                if (item < large && item > small) med = item;
            }

            if (large - small == (large - med) * 2) return true;

            else return false;
        }
    }
}
