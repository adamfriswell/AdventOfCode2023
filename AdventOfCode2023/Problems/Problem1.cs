namespace AdventOfCode2023.Problems
{
    public static class Problem1
    {
        public static int Solve()
        {
            var input = File.ReadLines(Path.Combine(Directory.GetCurrentDirectory(), "Inputs", "Problem1Input.txt")).ToList();
            return GetCalibrationSum(input);
        }

        public static int GetCalibrationSum(List<string> input) => input.Sum(x => GetCalibrationValue(x));

        public static int GetCalibrationValue(string inputLine)
        {
            var digitsOnly = inputLine.Where(x => char.IsDigit(x))
                                      .Select(x => Convert.ToInt32(x.ToString()));

            return Convert.ToInt32(string.Format("{0}{1}", digitsOnly.First(), digitsOnly.Last()));
        }
    }
}
