using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class FormingAMagicSquareTest : Test
    {
        private readonly FormingAMagicSquareExercise _formingAMagicSquareExercise = new FormingAMagicSquareExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var input = ParseSquare("4 9 2\r\n3 5 7\r\n8 1 5");

            var result = _formingAMagicSquareExercise.FormingMagicSquare(input);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = ParseSquare("4 8 2\r\n4 5 7\r\n6 1 6");

            var result = _formingAMagicSquareExercise.FormingMagicSquare(input);

            Assert.AreEqual(4, result);
        }

        

    }
}