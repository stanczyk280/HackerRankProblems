using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingEasy
{
    public static class DiagonalDifference
    {
        public static int CalculateDifference(List<List<int>> arr)
        {
            int i = 0;
            int k = arr.Count() - 1;
            int sumFirst = 0;
            int sumSecond = 0;
            foreach (List<int> list in arr)
            {
                sumFirst += list[i];
                sumSecond += list[k];
                i++;
                k--;
            }
            return Math.Abs(sumFirst - sumSecond);
        }
    }
}