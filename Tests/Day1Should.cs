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
            new object[] { new[] { "14gxqgqsqqbxfpxnbccjc33eight", "eight2sevenkl" }, 35 },
            new object[] { new[] { "14gxqgqsqqbxfpxnbccjc33eight", "eight2sevenkl", "mrjstg5onetwoeightgcczx8vgrgl", "9246", "ninetwo2crrqk2grsctqxqbcrmrdsqbrz9eight" }, 218 }
        };
    }
}