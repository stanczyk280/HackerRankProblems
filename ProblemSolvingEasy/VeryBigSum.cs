using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingEasy
{
    public static class VeryBigSum
    {
        public static long CalculateSum(List<long> ar)
        {
            long sum = 0;
            foreach (long n in ar)
            {
                sum += n;
            }
            return sum;
        }
    }
}