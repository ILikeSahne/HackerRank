using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving.Exercises
{
    public class AngryProfessorExercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(3, ParseIntList("-1 -3 4 2"));
            Console.WriteLine(answer);
        }

        public string Solve(int threshold, List<int> studentTimes)
        {
            var onTimeStudents = studentTimes.Count(time => time <= 0);

            return onTimeStudents >= threshold ? "NO" : "YES";
        }
    }
}