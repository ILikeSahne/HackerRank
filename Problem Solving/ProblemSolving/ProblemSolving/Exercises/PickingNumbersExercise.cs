using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Exercises
{
    public class PickingNumbersExercise : Exercise
    {
        public override void Run()
        {
            var a = Parse("4 6 5 3 3 1");
            var result = PickingNumbers(a);
            Console.WriteLine(result);
        }

        public int PickingNumbers(List<int> a)
        {
            var alreadySearched = new HashSet<int>();
            var max = int.MinValue;
            foreach (var num in a)
            {
                if(alreadySearched.Contains(num))
                    continue;

                var amount1 = Count(a, num);
                var amount2 = Count(a, num - 1);
                alreadySearched.Add(num);

                if (amount1 > max)
                    max = amount1;
                if (amount2 > max)
                    max = amount2;
            }

            return max;
        }

        private int Count(List<int> a, int num)
        {
            return a.Count(x => x == num || x == num + 1);
        }

        private List<int> Parse(string input)
        {
            var a = new List<int>();
            foreach (var num in input.Split())
                a.Add(int.Parse(num));
            return a;
        }
    }
}
