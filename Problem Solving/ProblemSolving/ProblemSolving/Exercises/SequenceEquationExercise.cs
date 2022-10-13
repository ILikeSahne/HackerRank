using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving.Exercises
{
    public class SequenceEquationExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(ParseIntList("2 3 1"));
            PrintList(answer);
        }

        public List<int> Solve(List<int> p)
        {
            var min = p.Min();
            var max = p.Max();

            var values = new int[max];

            for (var i = 0; i < p.Count; i++)
            {
                var num = p[i] - min;
                num = p[num] - min;
                values[num] = i + min;  
            }

            return values.ToList();
        }
    }
}