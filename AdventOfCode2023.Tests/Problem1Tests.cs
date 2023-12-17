using AdventOfCode2023.Problems;

namespace AdventOfCode2023.Tests;

public class Problem1Tests
{
    [Theory]
    [InlineData("1abc2",12)]
    [InlineData("pqr3stu8vwx",38)]
    [InlineData("a1b2c3d4e5f",15)]
    [InlineData("treb7uchet",77)]
    public void GivenTestInputs_GetCalibrationValue_ShouldGetExpectedValue(string input, int expectedValue)
    {
        var result = Problem1.GetCalibrationValue(input);
        Assert.Equal(expectedValue, result);
    }

    [Fact]
    public void GivenTestInputs_GetCalibrationSum_ShouldGetExpectedSum()
    {
        var result = Problem1.GetCalibrationSum(new() { "1abc2", "pqr3stu8vwx", "a1b2c3d4e5f", "treb7uchet" });
        Assert.Equal(142, result);
    }

    [Theory]
    [InlineData("two1nine", 29)]
    [InlineData("eightwothree", 83)]
    [InlineData("abcone2threexyz", 13)]
    [InlineData("xtwone3four", 24)]
    [InlineData("4nineeightseven2", 42)]
    [InlineData("zoneight234", 14)]
    [InlineData("7pqrstsixteen", 76)]
    public void GivenStringNumberTestInputs_GetCalibrationValueAndParseFirst_ShouldGetExpectedValue(string input, int expectedValue)
    {
        var result = Problem1.GetCalibrationValue(input, parseFirst: true);
        Assert.Equal(expectedValue, result);
    }


    [Fact]
    public void GivenTestInputsReadAsStringsAlso_GetCalibrationSumAndParseFirst_ShouldGetExpectedSum()
    {
        var result = Problem1.GetCalibrationSum(new() { "two1nine", "eightwothree", "abcone2threexyz","xtwone3four",
            "4nineeightseven2", "zoneight234", "7pqrstsixteen"}, parseFirst: true);
        Assert.Equal(281, result);
    }

    [Theory]
    [InlineData("one", 1)]
    [InlineData("two", 2)]
    [InlineData("three", 3)]
    [InlineData("four", 4)]
    [InlineData("five", 5)]
    [InlineData("six", 6)]
    [InlineData("seven", 7)]
    [InlineData("eight", 8)]
    [InlineData("nine", 9)]

    public void GivenSingleDigitAsString_ParseLineForDigitsAsLetters_ShouldGetExpectedValue(string input, int expectedValue)
    {
        var result = Problem1.ParseLineForDigitsAsLetters(input);
        Assert.Equal(expectedValue.ToString(), result);
    }

    [Theory]
    [InlineData("eightwo", "8wo")]
    [InlineData("sevenine", "7ine")]
    public void GivenTwoDigitsSharingLastAndFirstChar_ParseLineForDigitsAsLetter_ShouldOnlyParseFirstDigit(string input, string expectedResult)
    {
        var result = Problem1.ParseLineForDigitsAsLetters(input);
        Assert.Equal(expectedResult, result);
    }
}