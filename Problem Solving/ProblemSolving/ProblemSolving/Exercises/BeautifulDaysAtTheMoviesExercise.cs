using System;
using System.Linq;

namespace ProblemSolving.Exercises
{
    public class BeautifulDaysAtTheMoviesExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(13, 43, 3);
            Console.WriteLine(answer);
        }

        public int Solve(int start, int end, int divisor)
        {
            var count = 0;
            for (var i = start; i <= end; i++)
            {
                var num = i - Reverse(i);
                
                if (num % divisor == 0)
                    count++;
            }

            return count;
        }

        private int Reverse(int x)
        {
            var reverse = 0;

            while (x > 0)
            {
                reverse *= 10;
                reverse += x % 10;
                x /= 10;
            }

            return reverse;
        }
    }
}