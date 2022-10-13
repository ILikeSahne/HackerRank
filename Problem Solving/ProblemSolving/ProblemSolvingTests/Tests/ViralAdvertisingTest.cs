using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class ViralAdvertisingTest : Test
    {
        private readonly ViralAdvertisingExercise _viralAdvertisingExercise = new ViralAdvertisingExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _viralAdvertisingExercise.Solve(3);

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _viralAdvertisingExercise.Solve(5);

            Assert.AreEqual(24, result);
        }
    }
}