using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTests
{
    public class Test
    {
        protected List<List<int>> ParseSquare(string s)
        {
            var lines = s.Split('\n');
            return lines.Select(line => line.Split(' ').Select(int.Parse).ToList()).ToList();
        }

        protected List<int> ParseIntList(string input)
        {
            return input.Split().Select(int.Parse).ToList();
        }
    }
}
