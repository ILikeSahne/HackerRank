using System;

namespace ProblemSolving.Exercises
{
    public class ViralAdvertisingExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(3);
            Console.WriteLine(answer);
        }

        public int Solve(int n)
        {
            var shared = 5;
            var sum = 0;
            for (var i = 0; i < n; i++)
            {
                var liked = shared / 2;
                shared = liked * 3;
                sum += liked;
            }

            return sum;
        }
    }
}