using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class SequenceEquationTest : Test
    {
        private readonly SequenceEquationExercise _sequenceEquationExercise = new SequenceEquationExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _sequenceEquationExercise.Solve(ParseIntList("2 3 1"));

            var expected = ParseIntList("2 3 1");
            AssertList(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _sequenceEquationExercise.Solve(ParseIntList("4 3 5 1 2"));

            var expected = ParseIntList("1 3 5 4 2");
            AssertList(expected, result);
        }
        
    }
}