using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        public bool matchingPlates(char[] meals, char[] stack)
        {
            bool match = false;
            if (meals.Length <= stack.Length)
            {
                for (int i = 0; i < meals.Length; i++)
                {
                    if (stack[i] == meals[i])
                    {
                        match = true;
                    }
                }
            }
            return match;
        }


    


}
}
