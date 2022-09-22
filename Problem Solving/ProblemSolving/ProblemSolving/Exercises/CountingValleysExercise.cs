using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Exercises
{
    public class CountingValleysExercise : Exercise
    {
        public override void Run()
        {
            var answer = CountingValleys(8, "UDDDUDUU");
            Console.WriteLine(answer);
        }

        public int CountingValleys(int steps, string path)
        {
            var altitude = 0;
            var valleys = 0;
            foreach (var c in path)
            {
                if (c == 'U')
                {
                    altitude++;
                    if(altitude == 0)
                        valleys++;
                }

                if (c == 'D')
                    altitude--;
            }

            return valleys;
        }
    }
}
