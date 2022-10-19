using System;
using System.Management.Instrumentation;
using System.Runtime.ExceptionServices;

namespace ProblemSolving.Exercises
{
    public class SherlockAndSquaresExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(100, 1000);
            Console.WriteLine(answer);
        }

        public int Solve(int from, int to)
        {
            from = (int) Math.Sqrt(from - 1);
            to = (int) Math.Sqrt(to);
            return to - from;
        }
    }
}