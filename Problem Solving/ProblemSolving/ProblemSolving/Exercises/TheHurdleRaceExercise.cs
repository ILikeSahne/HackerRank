using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Exercises
{
    public class TheHurdleRaceExercise : Exercise
    {
        public override void Run()
        {
            var input = ParseIntList("1 6 3 5 2");
            var answer = HurdleRace(4, input);
            Console.WriteLine(answer);
        }

        public int HurdleRace(int k, List<int> height)
        {
            var max = height.Max();
            var amount = Math.Max(0, max - k);
            return amount;
        }
    }
}
