namespace ProblemSolvingEasy
{
    public static class BirthdayCakeCandles
    {
        public static int CalculateCandles(List<int> candles)
        {
            int tallest = candles.Max();
            int count = candles.Where(x => x.Equals(tallest)).Count();
            return count;
        }
    }
}