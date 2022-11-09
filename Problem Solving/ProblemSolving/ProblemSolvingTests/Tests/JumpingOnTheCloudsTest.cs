using FluentAssertions;
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
            var result = _jumpingOnTheCloudsExercise.Solve(ParseIntList("0 0 1 0 0 1 0"));

            result.Should().Be(4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _jumpingOnTheCloudsExercise.Solve(ParseIntList("0 0 0 1 0 0"));

            result.Should().Be(3);
        }
        
    }
}