using System;

namespace ProblemSolving.Exercises
{
    public class UtopianTreeExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(5);
            Console.WriteLine(answer);
        }

        public int Solve(int n)
        {
            var height = 1;
            for (var i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    height *= 2;
                else
                    height++;
            }

            return height;
        }
    }
}