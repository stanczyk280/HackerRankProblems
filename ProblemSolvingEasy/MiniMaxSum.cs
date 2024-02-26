namespace ProblemSolvingEasy
{
    //https://www.hackerrank.com/challenges/mini-max-sum/problem
    public static class MiniMaxSum
    {
        public static void PrintMinMax(List<int> arr)
        {
            List<long> longArr = arr.ConvertAll(i => (long)i);
            List<long> list = new List<long>();

            for (int i = 0; i < arr.Count; i++)
            {
                list.Add(longArr.Sum() - longArr[i]);
            }

            list.Sort();

            Console.WriteLine(list[0] + " " + list[list.Count - 1]);
        }
    }
}