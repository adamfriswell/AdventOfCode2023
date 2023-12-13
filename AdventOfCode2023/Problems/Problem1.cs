namespace AdventOfCode2023.Problems
{
    public static class Problem1
    {
        public static int Solve()
        {
            var input = File.ReadLines(Path.Combine(Directory.GetCurrentDirectory(), "Inputs", "Problem1Input.txt")).ToList();

            var sum = 0;
            foreach (var line in input)
            {
                var calibrationValue = GetCalibrationValue(line);
                sum += calibrationValue;
            }

            return sum;
        }

        public static int GetCalibrationValue(string inputLine)
        {
            List<int> digitsOnly = new(){ };
            foreach (var c in inputLine.ToCharArray())
            {
                if (char.IsDigit(c))
                {
                    digitsOnly.Add(Convert.ToInt32(c.ToString()));
                }
            }

            return Convert.ToInt32(string.Format("{0}{1}", digitsOnly.First(), digitsOnly.Last()));
        }
    }
}
