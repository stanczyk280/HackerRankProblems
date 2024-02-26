namespace ProblemSolvingEasy
{
    //https://www.hackerrank.com/challenges/compare-the-triplets/problem
    public static class CompareTheTriplets
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            List<int> score = new List<int>();
            int aliceScore = 0, bobScore = 0;

            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i]) aliceScore++;
                if (a[i] < b[i]) bobScore++;
            }
            score.Add(aliceScore);
            score.Add(bobScore);
            return score;
        }
    }
}