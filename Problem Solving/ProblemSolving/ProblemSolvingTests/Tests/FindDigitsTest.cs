using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class FindDigitsTest : Test
    {
        private readonly FindDigitsExercise _findDigitsExercise = new FindDigitsExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _findDigitsExercise.Solve(12);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _findDigitsExercise.Solve(1012);

            Assert.AreEqual(3, result);
        }
        
    }
}