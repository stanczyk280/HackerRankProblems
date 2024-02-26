using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingEasy
{
    //https://www.hackerrank.com/challenges/plus-minus/problem
    public static class PlusMinus
    {
        public static void PrintRatios(List<int> arr)
        {
            float pos = 0, neg = 0, zeroes = 0;
            float n = arr.Count;

            foreach (int number in arr)
            {
                if (number > 0) pos++;
                if (number < 0) neg++;
                if (number == 0) zeroes++;
            }
            float ratioPos = pos / n;
            float ratioNeg = neg / n;
            float ratioZeroes = zeroes / n;
            Console.WriteLine(string.Format("{0:N6}", ratioPos));
            Console.WriteLine(string.Format("{0:N6}", ratioNeg));
            Console.WriteLine(string.Format("{0:N6}", ratioZeroes));
        }
    }
}