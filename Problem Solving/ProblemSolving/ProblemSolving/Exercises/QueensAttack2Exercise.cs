using System;
using System.Collections.Generic;

namespace ProblemSolving.Exercises
{
    public class QueensAttack2Exercise : Exercise
    {
        public override void Run()
        {
            var answer = Solve(4, 0, 4, 4, new List<List<int>>());
            Console.WriteLine(answer);
        }

        private List<List<char>> setFields = new List<List<char>>();

        public int Solve(int size, int k, int queen_row, int queen_column, List<List<int>> obstacles)
        {
            queen_row--;
            queen_column--;
            var obstaclesSet = new HashSet<int>();

            foreach (var o in obstacles)
            {
                obstaclesSet.Add((o[0] - 1) * size + (o[1] - 1));
            }

            for (var i = 0; i < size; i++)
            {
                setFields.Add(new List<char>());
                for (var j = 0; j < size; j++)
                {
                    setFields[i].Add(' ');
                }
            }

            var sum = 0;
            sum += CheckPos(queen_row + 1, queen_column - 1, 1, -1, size, obstaclesSet);
            sum += CheckPos(queen_row + 1, queen_column, 1, 0, size, obstaclesSet);
            sum += CheckPos(queen_row + 1, queen_column + 1, 1, 1, size, obstaclesSet);
            sum += CheckPos(queen_row, queen_column + 1, 0, 1, size, obstaclesSet);
            sum += CheckPos(queen_row - 1, queen_column + 1, -1, 1, size, obstaclesSet);
            sum += CheckPos(queen_row - 1, queen_column, -1, 0, size, obstaclesSet);
            sum += CheckPos(queen_row - 1, queen_column - 1, -1, -1, size, obstaclesSet);
            sum += CheckPos(queen_row, queen_column - 1, 0, -1, size, obstaclesSet);

            setFields[queen_row][queen_column] = 'Q';

            foreach (var obstacle in obstaclesSet)
            {
                var col = obstacle / size;
                var row = obstacle % size;

                setFields[col][row] = 'O';
            }

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    Console.Write(setFields[i][j] + " ");
                }
                Console.WriteLine();
            }

            return sum;
        }

        private int CheckPos(int row, int col, int xPlus, int yPlus, int size, HashSet<int> obstacles)
        {
            if (col < 0 || col >= size)
                return 0;
            if (row < 0 || row >= size)
                return 0;

            if (obstacles.Contains(row * size + col))
                return 0;

            setFields[row][col] = 'x';

            return CheckPos(row + xPlus, col + yPlus, xPlus, yPlus, size, obstacles) + 1;
        }
    }
}