using System;

namespace ProblemSolving.Exercises
{
    public class CatsAndAMouseExercise : Exercise
    {
        public override void Run()
        {
            var answer = CatAndMouse(1, 2, 3);
            Console.WriteLine(answer);
        }

        public string CatAndMouse(int cat1, int cat2, int mouse)
        {
            var dif1 = Math.Abs(mouse - cat1);
            var dif2 = Math.Abs(mouse - cat2);

            if (dif1 == dif2)
                return "Mouse C";

            return dif1 < dif2 ? "Cat A" : "Cat B";
        }
    }
}