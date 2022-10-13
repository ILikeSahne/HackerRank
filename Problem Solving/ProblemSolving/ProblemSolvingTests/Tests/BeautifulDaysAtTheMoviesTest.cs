using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class BeautifulDaysAtTheMoviesTest : Test
    {
        private readonly BeautifulDaysAtTheMoviesExercise _beautifulDaysAtTheMoviesExercise = new BeautifulDaysAtTheMoviesExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _beautifulDaysAtTheMoviesExercise.Solve(20, 23, 6);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _beautifulDaysAtTheMoviesExercise.Solve(13, 45, 3);

            Assert.AreEqual(33, result);
        }

    }
}