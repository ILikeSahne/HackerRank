using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace ProblemSolvingTests
{
    public class Test
    {
        protected List<List<int>> ParseSquare(string s)
        {
            var lines = s.Split('\n');
            return lines.Select(line => line.Split(' ').Select(int.Parse).ToList()).ToList();
        }

        protected List<string> ParseStringList(string input)
        {
            return input.Split().ToList();
        }

        protected List<int> ParseIntList(string input)
        {
            return input.Split().Select(int.Parse).ToList();
        }

        protected int[] ParseIntArray(string input)
        {
            return input.Split().Select(int.Parse).ToArray();
        }

        protected string ReadFile(string path)
        {
            return File.ReadAllText($"../../../TestCases/{path}");
        }

        protected void AssertList<T>(List<T> expected, List<T> actual)
        {
            expected.Count.Should().Be(actual.Count);

            for(var i = 0; i < expected.Count; i++)
            {
                expected[i].Should().Be(actual[i]);
            }
        }
    }
}
