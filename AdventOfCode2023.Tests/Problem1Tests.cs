using AdventOfCode2023.Problems;

namespace AdventOfCode2023.Tests;

public class Problem1Tests
{
    [Theory]
    [InlineData("1abc2",12)]
    [InlineData("pqr3stu8vwx",38)]
    [InlineData("a1b2c3d4e5f",15)]
    [InlineData("treb7uchet",77)]
    public void GivenTestInputs_GetCalibrationValue_ShouldGetExpectedAnswer(string input, int expectedOutput)
    {
        var result = Problem1.GetCalibrationValue(input);
        Assert.Equal(result, expectedOutput);
    }
}