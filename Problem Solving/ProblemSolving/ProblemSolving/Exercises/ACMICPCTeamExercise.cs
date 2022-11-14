using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving.Exercises
{
    public class ACMICPCTeamExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(ParseStringList("11101 10101 11001 10111 10000 01110"));
            
            PrintList(answer);
        }

        public List<int> Solve(List<string> topic)
        {
            var results = new Dictionary<int, int>();

            for (var i = 0; i < topic.Count; i++)
            {
                for (var j = i + 1; j < topic.Count; j++)
                {
                    var val = Count(topic[i], topic[j]);
                    
                    if (!results.ContainsKey(val))
                    {
                        results.Add(val, 1);
                    }
                    else
                    {
                        results[val]++;
                    }
                }
            }

            var highest = results.OrderByDescending(kv => kv.Key).First();
            return new List<int>
            {
                highest.Key, highest.Value
            };
        }

        private int Count(string s1, string s2)
        {
            return s1.Length != s2.Length ? 0 : s1.Where((t, i) => t == '1' || s2[i] == '1').Count();
        }
    }
}