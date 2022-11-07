using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace ProblemSolving.Exercises
{
    public class RepeatedStringExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve("aba", 10);
            Console.WriteLine(answer);
        }

        public long Solve(string s, long n)
        {
            var count = s.Count(c => c == 'a');

            var repeats = n / s.Length;

            var end = n % s.Length;

            var endCount = s.Substring(0, (int) end).Count(c => c == 'a');

            return count * repeats + endCount;
        }
    }
}