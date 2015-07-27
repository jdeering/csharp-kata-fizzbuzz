using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class FizzBuzz
    {
        public static List<string> To(int value)
        {
            var list = new List<string>();

            for (var i = 1; i <= value; i++)
            {
                if(i == 3) list.Add("Fizz");
                else list.Add(i.ToString());
            }

            return list;
        }

        public static string Of(int i)
        {
            return "1";
        }
    }
}
