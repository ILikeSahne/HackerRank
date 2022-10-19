using System;

namespace ProblemSolving.Exercises
{
    public class LibraryFineExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(6, 6, 2015, 6, 6, 2015);
            Console.WriteLine(answer);
        }

        public int Solve(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            if (y1 > y2)
                return 10_000;

            if (y1 < y2)
                return 0;

            if (m1 > m2)
                return (m1 - m2) * 500;

            if (m1 < m2)
                return 0;

            if (d1 > d2)
                return (d1 - d2) * 15;

            return 0;
        }
    }
}