using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ProblemSolving.Exercises
{
    public class FormingAMagicSquareExercise : Exercise
    {
        private readonly List<List<int>> _possibleMagicSquares = new List<List<int>>
        {
            new List<int> {8, 1, 6, 3, 5, 7, 4, 9, 2},
            new List<int> {6, 1, 8, 7, 5, 3, 2, 9, 4},
            new List<int> {4, 3, 8, 9, 5, 1, 2, 7, 6},
            new List<int> {2, 7, 6, 9, 5, 1, 4, 3, 8},
            new List<int> {2, 9, 4, 7, 5, 3, 6, 1, 8},
            new List<int> {4, 9, 2, 3, 5, 7, 8, 1, 6},
            new List<int> {6, 7, 2, 1, 5, 9, 8, 3, 4},
            new List<int> {8, 3, 4, 1, 5, 9, 6, 7, 2}
        };

        public override void Run()
        {
            var input = ParseSquare("4 9 2\r\n3 5 7\r\n8 1 5");

            var answer = FormingMagicSquare(input);
            Console.WriteLine(answer);
        }

        public int FormingMagicSquare(List<List<int>> s)
        {
            var normal = ToNormal(s);
            var smallest = int.MaxValue;
            foreach (var magicSquare in _possibleMagicSquares)
            {
                var dist = GetDistance(normal, magicSquare);
                if (dist < smallest)
                    smallest = dist;
            }
            return smallest;
        }

        private List<int> ToNormal(List<List<int>> s)
        {
            return s.SelectMany(row => row).ToList();
        }

        private int GetDistance(List<int> s, List<int> magicSquare)
        {
            return s.Select((t, i) => Math.Abs(t - magicSquare[i])).Sum();
        }
    }
}