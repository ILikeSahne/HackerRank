using System;

namespace ProblemSolving.Exercises
{
    public class TaumAndBdayExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(10, 10, 1, 1, 1);
            Console.WriteLine(answer);
        }

        public long Solve(long b, long w, long bc, long wc, long z)
        {
            var smallestBc = Math.Min(bc, wc + z);
            var smallestWc = Math.Min(wc, bc + z);

            return b * smallestBc + w * smallestWc;
        }
    }
}