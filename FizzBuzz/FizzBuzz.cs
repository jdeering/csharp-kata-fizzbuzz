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
            
            foreach (var i in Enumerable.Range(1, value))
            {
                list.Add(FizzBuzz.Of(i));
            }

            return list;
        }

        public static string Of(int i)
        {
            if (i % 15 == 0) return "FizzBuzz";
            if (i % 3 == 0) return "Fizz";
            if (i % 5 == 0) return "Buzz";
            return i.ToString();
        }
    }
}
