using AdventOfCode2023;

namespace Tests
{
    [TestFixture]
    public class Day1Should
    {
        [TestCaseSource(nameof(_totalSources))]
        public void ShouldCalculateTotalOfLineValues(IEnumerable<string> lines, int expected)
        {
            Assert.That(Day1.CalculateTotal(lines), Is.EqualTo(expected));
        }

        private static object[] _totalSources = {
            new object[] { new[] { "two1nine", "eightwothree" }, 112 },
            new object[] { new[] { "two1nine", "eightwothree", "abcone2threexyz", "xtwone3four", "4nineeightseven2", "zoneight234", "7pqrstsixteen" }, 281 }
        };
    }
}