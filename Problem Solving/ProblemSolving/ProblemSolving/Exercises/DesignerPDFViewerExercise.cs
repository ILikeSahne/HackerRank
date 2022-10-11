using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Exercises
{
    public class DesignerPDFViewerExercise : Exercise
    {
        public override void Run()
        {
            var input = ParseIntList("1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5");
            var answer = DesignerPdfViewer(input, "abc");
            Console.WriteLine(answer);
        }

        public int DesignerPdfViewer(List<int> heights, string word)
        {
            var highest = word.Select(c => heights[c - 'a']).Max();
            return highest * word.Length;
        }
    }
}
