using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving.Exercises
{
    public class EqualizeTheArrayExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(ParseIntList("3 3 2 1 3"));
            Console.WriteLine(answer);
        }

        public int Solve(List<int> arr)
        {
            var mostOften = arr.GroupBy(x => x).OrderByDescending(group => group.Count()).Select(group => group.Key)
                .First();
            return arr.Count - arr.Count(x => x == mostOften);
        }
    }
}