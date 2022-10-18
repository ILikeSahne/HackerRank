using System;

namespace ProblemSolving.Exercises
{
    public class AppendAndDeleteExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve("y", "yu", 2);
            Console.WriteLine(answer);
        }

        public string Solve(string isString, string targetString, int k)
        {
            var len = isString.Length;
            var i = 0;
            for (; i < Math.Min(isString.Length, targetString.Length); i++)
            {
                if (isString[i] != targetString[i])
                    break;
            }

            var removes = Math.Abs(len - i);
            var adds = targetString.Length - (len - removes);

            var total = removes + adds;

            if (total <= k)
            {
                if ((k - total) % 2 == 0)
                    return "Yes";

                var lenAfterRemoves = len - removes;

                k -= adds;

                if (lenAfterRemoves * 2 < k)
                    return "Yes";
            }

            return "No";
        }
    }
}