﻿namespace AdventOfCode2023.Problems
{
    public static class Problem1
    {
        private static Dictionary<int, string> _digitsAsLetters = new() { { 1, "one" }, { 2, "two" }, { 3, "three" }, { 4, "four" }, { 5, "five" }, { 6, "six" }, { 7, "seven" }, { 8, "eight" }, { 9, "nine" } };

        public static int SolvePart1() => Solve(parseFirst: false);
        public static int SolvePart2() => Solve(parseFirst: true);

        private static int Solve(bool parseFirst)
        {
            var input = File.ReadLines(Path.Combine(Directory.GetCurrentDirectory(), "Inputs", "Problem1Input.txt")).ToList();
            return GetCalibrationSum(input, parseFirst);
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
            for (int i = 0; i < inputLine.Length; i++)
            {
                var c = inputLine[i];
                if (char.IsDigit(c))
                {
                    continue;
                }

                foreach (var d in _digitsAsLetters)
                {
                    var start = i; 
                    var end = d.Value.Length;
                    if (start + end <= inputLine.Length)
                    {
                        var digitAtPosition = inputLine.Substring(start, end);
                        if (d.Value.Equals(digitAtPosition))
                        {
                            inputLine = inputLine.Replace(d.Value, d.Key.ToString());
                        }
                    }

                }
            }
            return inputLine;
        }
    }
}