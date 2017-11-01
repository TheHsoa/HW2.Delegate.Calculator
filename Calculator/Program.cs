using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    internal class Program
    {
        private static void Main()
        {
            var num = new[] { 1, 2, 3, 4 };
            Console.WriteLine(GetValue(num, (x, y) => x + y));

            Console.WriteLine(GetValue(num, (x, y) => x * y));

            Console.ReadKey();
        }

        private static int GetValue(IEnumerable<int> num, Func<int, int, int> calculate)
        {
            return num.Sum(n => calculate(n, 1));
        }
    }
}
