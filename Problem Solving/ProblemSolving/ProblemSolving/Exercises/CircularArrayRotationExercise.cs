using System;
using System.Collections.Generic;

namespace ProblemSolving.Exercises
{
    public class CircularArrayRotationExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(ParseIntList("3 4 5"), 2, ParseIntList("1 2"));
            PrintList(answer);
        }

        public List<int> Solve(List<int> array, int rotations, List<int> queries)
        {
            rotations %= array.Count;
            rotations = array.Count - rotations;

            var returnValues = new List<int>();
            
            foreach (var q in queries)
            {
                returnValues.Add(array[(q + rotations) % array.Count]);
            }

            return returnValues;
        }
    }
}