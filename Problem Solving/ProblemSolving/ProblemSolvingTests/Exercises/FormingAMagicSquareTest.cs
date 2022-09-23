using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Exercises
{
    [TestClass]
    public class FormingAMagicSquareTest
    {
        private readonly FormingAMagicSquareExercise _formingAMagicSquareExercise = new FormingAMagicSquareExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var input = Parse("4 9 2\r\n3 5 7\r\n8 1 5");

            var result = _formingAMagicSquareExercise.FormingMagicSquare(input);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = Parse("4 8 2\r\n4 5 7\r\n6 1 6");

            var result = _formingAMagicSquareExercise.FormingMagicSquare(input);

            Assert.AreEqual(4, result);
        }

        private List<List<int>> Parse(string s)
        {
            var lines = s.Split('\n');
            return lines.Select(line => line.Split(' ').Select(int.Parse).ToList()).ToList();
        }

    }
}