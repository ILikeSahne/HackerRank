using FluentAssertions;
using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class ACMICPCTeamTest : Test
    {
        private readonly ACMICPCTeamExercise _aCMICPCTeamExercise = new ACMICPCTeamExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var answer = ParseIntList("5 2");

            var result = _aCMICPCTeamExercise.Solve(ParseStringList("10101 11100 11010 00101"));

            result.Should().BeEquivalentTo(answer);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var answer = ParseIntList("5 6");

            var result = _aCMICPCTeamExercise.Solve(ParseStringList("11101 10101 11001 10111 10000 01110"));

            result.Should().BeEquivalentTo(answer);
        }
        
    }
}