using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingEasy
{
    public static class Staircase
    {
        public static void PrintStaircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(string.Concat(Enumerable.Repeat(' ', n - i)));
                Console.WriteLine(string.Concat(Enumerable.Repeat('#', i)));
            }
        }
    }
}