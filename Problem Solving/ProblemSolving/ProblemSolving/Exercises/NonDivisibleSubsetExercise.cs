using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving.Exercises
{
    public class NonDivisibleSubsetExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(3, ParseIntList("1 7 2 4"));
            Console.WriteLine(answer);
        }

        public int Solve(int divisor, List<int> numbers)
        {
            var counter = new int[divisor];

            for (var i = 0; i < counter.Length; i++)
            {
                counter[i] = 0;
            }

            foreach (var n in numbers)
            {
                counter[n % divisor]++;
            }

            if (divisor % 2 == 0)
                counter[divisor / 2] = Math.Min(counter[divisor / 2], 1);

            var re = Math.Min(counter[0], 1);

            for (var i = 1; i <= divisor / 2; i++)
            {
                re += Math.Max(counter[i], counter[divisor - i]);
            }
                
            return re;
        }
    }
}