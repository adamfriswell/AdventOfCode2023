namespace AdventOfCode2023.Problems
{
    public static class Problem1
    {
        private static Dictionary<int, string> _digitsAsLetters = new() { { 1, "one" }, { 2, "two" }, { 3, "three" }, { 4, "four" }, { 5, "five" }, { 6, "six" }, { 7, "seven" }, { 8, "eight" }, { 9, "nine" } };
       
        public static int SolvePart1()
        {
            var input = File.ReadLines(Path.Combine(Directory.GetCurrentDirectory(), "Inputs", "Problem1Input.txt")).ToList();
            return GetCalibrationSum(input);
        }

        public static int SolvePart2()
        {
            var input = File.ReadLines(Path.Combine(Directory.GetCurrentDirectory(), "Inputs", "Problem1Input.txt")).ToList();
            return GetCalibrationSum(input, parseFirst: true);
        }

        public static int GetCalibrationSum(List<string> input, bool parseFirst = false) => input.Sum(x => GetCalibrationValue(x, parseFirst));

        public static int GetCalibrationValue(string inputLine, bool parseFirst = false)
        {
            if (parseFirst) inputLine = ParseLineForDigitsAsLetters(inputLine);
            var digitsOnly = inputLine.Where(x => char.IsDigit(x))
                                      .Select(x => Convert.ToInt32(x.ToString()));
            return Convert.ToInt32(string.Format("{0}{1}", digitsOnly.First(), digitsOnly.Last()));
        }

        public static string ParseLineForDigitsAsLetters(string inputLine)
        {
            foreach (var d in _digitsAsLetters)
            {
                if (inputLine.Contains(d.Value))
                {
                    inputLine = inputLine.Replace(d.Value, d.Key.ToString());
                }
            }
            return inputLine;
        }
    }
}