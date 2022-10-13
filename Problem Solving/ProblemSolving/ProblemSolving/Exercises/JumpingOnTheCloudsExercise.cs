using System;

namespace ProblemSolving.Exercises
{
    public class JumpingOnTheCloudsExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(ParseIntArray("0 0 1 0"), 2);
            Console.WriteLine(answer);
        }

        public int Solve(int[] c, int k)
        {
            var energy = 100;
            for (var i = 0;;)
            {
                i += k;
                var pos = i % c.Length;

                energy--;
                if (c[pos] == 1)
                    energy -= 2;

                if (pos == 0)
                    return energy;
            }
        }
    }
}