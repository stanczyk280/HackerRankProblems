namespace ProblemSolvingEasy
{
    public static class GradingStudents
    {
        public static List<int> GradeStudents(List<int> grades)
        {
            double nearestVal = 0;
            int convertedNearestVal = 0;
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    continue;
                }
                else
                {
                    if (grades[i] % 5 >= 3)
                    {
                        nearestVal = 5 * Math.Round((double)grades[i] / 5.0);
                        convertedNearestVal = Convert.ToInt32(nearestVal);
                        grades[i] = convertedNearestVal;
                    }
                }
            }
            return grades;
        }
    }
}