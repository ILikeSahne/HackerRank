using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Exercises
{
    public class SockMerchantExercise : Exercise
    {
        public override void Run()
        {
            var input = ParseIntList("10 20 20 10 10 30 50 10 20");
            var answer = SockMerchant(9, input);
            Console.WriteLine(answer);
        }

        public int SockMerchant(int n, List<int> socks)
        {
            var amount = 0;
            var sockPairs = new HashSet<int>();
            foreach (var color in socks)
            {
                if (sockPairs.Contains(color))
                {
                    sockPairs.Remove(color);
                    amount++;
                }
                else
                {
                    sockPairs.Add(color);
                }
            }

            return amount;
        }
    }
}
