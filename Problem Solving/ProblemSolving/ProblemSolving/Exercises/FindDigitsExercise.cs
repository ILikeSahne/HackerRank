using System;

namespace ProblemSolving.Exercises
{
    public class FindDigitsExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(12);
            Console.WriteLine(answer);
        }

        public int Solve(int n)
        {
            var counter = 0;
            var temp = n;
            while (temp > 0)
            {
                var num = temp % 10;
                temp /= 10;

                if(num == 0)
                    continue;

                if (n % num == 0)
                    counter++;
            }
            return counter;
        }
    }
}