using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingEasy
{
    //https://www.hackerrank.com/challenges/simple-array-sum/problem
    public static class SimpleArraySum
    {
        public static int SumArray(List<int> ar)
        {
            int sum = 0;
            foreach (int i in ar)
            {
                sum += i;
            }
            return sum;
        }
    }
}