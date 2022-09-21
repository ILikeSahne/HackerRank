using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Exercises
{
    public class DrawingBookExercise : Exercise
    {
        public override void Run()
        {
            var answer = PageCount(6, 2);
            Console.WriteLine(answer);
        }

        public int PageCount(int pages, int pageNumber)
        {
            var fromStart = pageNumber / 2;
            var fromEnd = (pages - pageNumber + pageNumber % 2) / 2;

            return Math.Min(fromStart, fromEnd);
        }
    }
}
