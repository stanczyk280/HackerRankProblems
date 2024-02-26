namespace ProblemSolvingEasy
{
    //https://www.hackerrank.com/challenges/apple-and-orange/problem
    public static class AppleAndOrange
    {
        public static void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int applesLanded = 0;
            int orangesLanded = 0;

            foreach (int apple in apples)
            {
                if (a + apple >= s && a + apple <= t) applesLanded++;
            }

            foreach (int orange in oranges)
            {
                if (b + orange >= s && b + orange <= t) orangesLanded++;
            }

            Console.WriteLine(applesLanded);
            Console.WriteLine(orangesLanded);
        }
    }
}