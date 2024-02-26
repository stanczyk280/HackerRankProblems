namespace ProblemSolvingEasy
{
    //https://www.hackerrank.com/challenges/time-conversion/problem
    public static class TimeConversion
    {
        public static string ConvertTime(string inputStringTime)
        {
            bool isPM = false;
            if (inputStringTime.Substring(inputStringTime.Length - 2) == "PM")
                isPM = true;

            string hourTime = inputStringTime.Substring(0, inputStringTime.Length - 8);
            string timeRest = inputStringTime.Substring(2, inputStringTime.Length - 4);
            int hourValue = 0;

            if (isPM)
            {
                if (hourTime[0] == '0')
                {
                    hourTime = hourTime.Substring(1);
                    hourValue = Convert.ToInt32(hourTime);
                    hourValue += 12;

                    hourTime = hourValue.ToString();
                    return hourTime + timeRest;
                }

                hourValue = Convert.ToInt32(hourTime);
                hourValue += 12;
                if (hourValue == 24)
                {
                    hourTime = "12";
                    return hourTime + timeRest;
                }
                hourTime = hourValue.ToString();
                return hourTime + timeRest;
            }

            if (hourTime == "12")
                return "00" + timeRest;

            return hourTime + timeRest;
        }
    }
}