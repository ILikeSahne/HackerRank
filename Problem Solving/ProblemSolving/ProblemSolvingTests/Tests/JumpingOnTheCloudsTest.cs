using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class JumpingOnTheCloudsTest : Test
    {
        private readonly JumpingOnTheCloudsExercise _jumpingOnTheCloudsExercise = new JumpingOnTheCloudsExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _jumpingOnTheCloudsExercise.Solve(ParseIntArray("0 0 1 0"), 2);

            Assert.AreEqual(96, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _jumpingOnTheCloudsExercise.Solve(ParseIntArray("0 0 1 0 0 1 1 0"), 2);

            Assert.AreEqual(92, result);
        }
        
    }
}