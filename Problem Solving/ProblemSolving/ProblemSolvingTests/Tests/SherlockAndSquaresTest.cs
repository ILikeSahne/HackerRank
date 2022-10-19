using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class SherlockAndSquaresTest : Test
    {
        private readonly SherlockAndSquaresExercise _sherlockAndSquaresExercise = new SherlockAndSquaresExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _sherlockAndSquaresExercise.Solve(3, 9);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _sherlockAndSquaresExercise.Solve(17, 24);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = _sherlockAndSquaresExercise.Solve(35, 70);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = _sherlockAndSquaresExercise.Solve(100, 1000);

            Assert.AreEqual(22, result);
        }

    }
}