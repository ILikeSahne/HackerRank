using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class NonDivisibleSubsetTest : Test
    {
        private readonly NonDivisibleSubsetExercise _nonDivisibleSubsetExercise = new NonDivisibleSubsetExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _nonDivisibleSubsetExercise.Solve(3, ParseIntList("1 7 2 4"));

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _nonDivisibleSubsetExercise.Solve(7, ParseIntList("278 576 496 727 410 124 338 149 209 702 282 718 771 575 436"));

            Assert.AreEqual(11, result);
        }
        
    }
}