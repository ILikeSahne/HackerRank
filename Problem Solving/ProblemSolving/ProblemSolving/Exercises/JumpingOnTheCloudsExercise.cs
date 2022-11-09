using System;
using System.Collections.Generic;

namespace ProblemSolving.Exercises
{
    public class JumpingOnTheCloudsExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(ParseIntList("0 0 1 0 0 1 0"));
            Console.WriteLine(answer);
        }

        public int Solve(List<int> clouds)
        {
            var pos = 0;
            var steps = 0;
            while (pos < clouds.Count - 1)
            {
                steps++;
                if (pos + 2 < clouds.Count) {
                    if (clouds[pos + 2] == 0)
                    {
                        pos += 2;
                        continue;
                    }
                }
                pos++;
            }
            return steps;
        }
    }
}