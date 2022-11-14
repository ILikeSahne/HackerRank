using FluentAssertions;
using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class TaumAndBdayTest : Test
    {
        private readonly TaumAndBdayExercise _taumAndBdayExercise = new TaumAndBdayExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _taumAndBdayExercise.Solve(10, 10, 1, 1, 1);

            result.Should().Be(20);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _taumAndBdayExercise.Solve(5, 9, 2, 3, 4);

            result.Should().Be(37);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = _taumAndBdayExercise.Solve(27984, 1402, 619246, 615589, 247954);

            result.Should().Be(18192035842);
        }

    }
}