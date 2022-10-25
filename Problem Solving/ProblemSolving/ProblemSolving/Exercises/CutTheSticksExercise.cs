using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving.Exercises
{
    public class CutTheSticksExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(ParseIntList("5 4 4 2 2 8"));
            PrintList(answer);
        }

        public List<int> Solve(List<int> sticks)
        {
            var returnList = new List<int>();
            while (true)
            {
                returnList.Add(sticks.Count);

                if (sticks.All(s => s == sticks[0]))
                {
                    return returnList;
                }

                var min = sticks.Min();
                for (var i = sticks.Count - 1; i >= 0; i--)
                {
                    sticks[i] -= min;
                    if (sticks[i] == 0)
                    {
                        sticks.RemoveAt(i);
                    }
                }
            }
        }
    }
}