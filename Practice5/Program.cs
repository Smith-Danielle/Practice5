using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Text.RegularExpressions;


namespace Practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(digPow(3456789, 5));
        }
        public static long digPow(int n, int p)
        {
            var num = n.ToString().ToArray();
            int power = p;
            long solution = 0;
            for (int i = 0; i < num.Length; i++)
            {
                solution += Convert.ToInt64(Math.Pow(Convert.ToInt64(num[i]) -48, power));
                power++;
            }
            double answer = Convert.ToDouble(solution) / Convert.ToDouble(n);
            Console.WriteLine(answer);
            if (answer % 1 == 0)
            {
                return Convert.ToInt64(answer);
            }
            return - 1;
        }
    }
}
