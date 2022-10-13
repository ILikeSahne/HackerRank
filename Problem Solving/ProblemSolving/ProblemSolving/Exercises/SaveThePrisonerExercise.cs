using System;

namespace ProblemSolving.Exercises
{
    public class SaveThePrisonerExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(4, 6, 2);
            Console.WriteLine(answer);
        }

        public int Solve(int prisoners, int amountCandy, int start)
        {
            var warn = (start + amountCandy - 2) % prisoners;
            return warn + 1;
        }
    }
}