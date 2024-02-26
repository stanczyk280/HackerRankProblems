namespace ProblemSolvingEasy
{
    //https://www.hackerrank.com/challenges/a-very-big-sum/problem
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