using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class CutTheSticksTest : Test
    {
        private readonly CutTheSticksExercise _cutTheSticksExercise = new CutTheSticksExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _cutTheSticksExercise.Solve(ParseIntList("5 4 4 2 2 8"));

            AssertList(ParseIntList("6 4 2 1"), result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _cutTheSticksExercise.Solve(ParseIntList("1 2 3 4 3 3 2 1"));

            AssertList(ParseIntList("8 6 4 1"), result);
        }
        
    }
}