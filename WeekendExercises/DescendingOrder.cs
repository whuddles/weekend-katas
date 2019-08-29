using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        public int DescendingOrder(int num)
        {
            int result = 0;
            List<string> list = new List<string>();
            string number = num.ToString();
            string newString = "";

            foreach (var item in number)
            {
                list.Add(item.ToString());
            }
            list.Sort();
            list.Reverse();
            number = string.Join("", list);
            result = int.Parse(number);
            return result;
        }
    }
}
