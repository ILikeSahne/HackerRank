using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class Exercise
    {
        public virtual void Run()
        { }

        protected List<List<int>> ParseSquare(string s)
        {
            var lines = s.Split('\n');
            return lines.Select(line => line.Split(' ').Select(int.Parse).ToList()).ToList();
        }

        protected List<int> ParseIntList(string input)
        {
            return input.Split().Select(int.Parse).ToList();
        }

        protected int[] ParseIntArray(string input)
        {
            return input.Split().Select(int.Parse).ToArray();
        }

        protected void PrintList<T>(List<T> list)
        {
            list.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}
