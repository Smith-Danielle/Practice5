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
            List<int> test = new List<int> { 1040, 1220, 1580 };
            Console.WriteLine(FindMissing(test));
        }
        public static int FindMissing(List<int> list)
        {

            if (list.Count == 3)
            {
                return list[1] - (list[0] - list[1]);
            }


            List<int> difference = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count - 1)
                {
                    difference.Add(list[i] - list[i + 1]);
                }
            }
      
            var common = difference.GroupBy(item => item).Where(item => item.Count() > 1).Select(item => item.Key);
            int answer = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count - 1 && list[i] - common.First() != list[i + 1])
                {
                    answer = list[i] - common.First();
                }
            }
            
            return answer;
            

        }
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> letterCount = new Dictionary<char, int>();
            var a = str.Where(item => item == 'a').Count();
            if (a > 0)
            {
                letterCount.Add('a', a);
            }
            var b = str.Where(item => item == 'b').Count();
            if (b > 0)
            {
                letterCount.Add('b', b);
            }
            var c = str.Where(item => item == 'c').Count();
            if (c > 0)
            {
                letterCount.Add('c', c);
            }
            var d = str.Where(item => item == 'd').Count();
            if (d > 0)
            {
                letterCount.Add('d', d);
            }
            var e = str.Where(item => item == 'e').Count();
            if (e > 0)
            {
                letterCount.Add('e', e);
            }
            var f = str.Where(item => item == 'f').Count();
            if (f > 0)
            {
                letterCount.Add('f', f);
            }
            var g = str.Where(item => item == 'g').Count();
            if (g > 0)
            {
                letterCount.Add('g', g);
            }
            var h = str.Where(item => item == 'h').Count();
            if (h > 0)
            {
                letterCount.Add('h', h);
            }
            var i = str.Where(item => item == 'i').Count();
            if (i > 0)
            {
                letterCount.Add('i', i);
            }
            var j = str.Where(item => item == 'j').Count();
            if (j > 0)
            {
                letterCount.Add('j', j);
            }
            var k = str.Where(item => item == 'k').Count();
            if (k > 0)
            {
                letterCount.Add('k', k);
            }
            var l = str.Where(item => item == 'l').Count();
            if (l > 0)
            {
                letterCount.Add('l', l);
            }
            var m = str.Where(item => item == 'm').Count();
            if (m > 0)
            {
                letterCount.Add('m', m);
            }
            var n = str.Where(item => item == 'n').Count();
            if (n > 0)
            {
                letterCount.Add('n', n);
            }
            var o = str.Where(item => item == 'o').Count();
            if (o > 0)
            {
                letterCount.Add('o', o);
            }
            var p = str.Where(item => item == 'p').Count();
            if (p > 0)
            {
                letterCount.Add('p', p);
            }
            var q = str.Where(item => item == 'q').Count();
            if (q > 0)
            {
                letterCount.Add('q', q);
            }
            var r = str.Where(item => item == 'r').Count();
            if (r > 0)
            {
                letterCount.Add('r', r);
            }
            var s = str.Where(item => item == 's').Count();
            if (s > 0)
            {
                letterCount.Add('s', s);
            }
            var t = str.Where(item => item == 't').Count();
            if (t > 0)
            {
                letterCount.Add('t', t);
            }
            var u = str.Where(item => item == 'u').Count();
            if (u > 0)
            {
                letterCount.Add('u', u);
            }
            var v = str.Where(item => item == 'v').Count();
            if (v > 0)
            {
                letterCount.Add('v', v);
            }
            var w = str.Where(item => item == 'w').Count();
            if (w > 0)
            {
                letterCount.Add('w', w);
            }
            var x = str.Where(item => item == 'x').Count();
            if (x > 0)
            {
                letterCount.Add('x', x);
            }
            var y = str.Where(item => item == 'y').Count();
            if (y > 0)
            {
                letterCount.Add('y', y);
            }
            var z = str.Where(item => item == 'z').Count();
            if (z > 0)
            {
                letterCount.Add('z', z);
            }
            return letterCount;
        }
        public static string Balance(string book)
        {
            var bookLine = book.Replace('\n', ' ');
            
            string books = string.Empty;
            
            for (int i = 0; i < bookLine.Length; i++)
            {
                if (char.IsLetterOrDigit(bookLine[i]) || bookLine[i] == ' ' || bookLine[i] == '.')
                {
                    books += bookLine[i];
                }
            }
            Console.WriteLine(books);
            var bookSpace = books.Replace("  ", " ");
            var breakUp = bookSpace.Split(" ");

            double expense = 0;
            int count = 0;
            
            double balances = Convert.ToDouble(breakUp[0]);
            Console.WriteLine(balances);
            List<string> balance = new List<string>();
            for (int i = 0; i < breakUp.Length; i++)
            {
                if (i >= 3 && i % 3 == 0)
                {
                    
                    expense += Convert.ToDouble(breakUp[i]);
                    balances -= Convert.ToDouble(breakUp[i]);
                    count++;
                    balance.Add(breakUp[i]);
                    balance.Add("Balance");
                    balance.Add(Math.Round(balances,2).ToString("0.00")); 
                }
                else
                {
                    balance.Add(breakUp[i]);
                }
            }
            
            string spaces = "Original Balance: ";
            for (int i = 0; i < balance.Count; i++)
            {
                if (i != 1 && i % 5 == 0)
                {
                    spaces += $"{balance[i]}";
                    spaces += '\n';
                }
                else
                {
                    if (i == balance.Count - 1)
                    {
                        spaces += $"{balance[i]}";
                    }
                    else
                    {
                        spaces += $"{balance[i]} ";
                    }
                }    
            }
            string average = (Math.Round(expense, 2) / Convert.ToDouble(count)).ToString("0.00");
            spaces += $"Total expense  {Math.Round(expense, 2).ToString("0.00")}\nAverage expense  {average}";
            Console.WriteLine(count);
            Console.WriteLine(expense);
            Console.WriteLine(average);
            Console.WriteLine(spaces);
            return "";
        }
        public static string DuplicateEncode(string word)
        {
            string wordLower = word.ToLower();
            var multiple = wordLower.GroupBy(item => item).Where(item => item.Count() > 1).Select(item => item.Key);
            string encode = string.Empty;
            for (int i = 0; i < wordLower.Length; i++)
            {
                if (multiple.Contains(wordLower[i]))
                {
                    encode += ")";
                }
                else
                {
                    encode += "(";
                }
            }
            return encode;
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
