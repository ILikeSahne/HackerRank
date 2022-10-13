using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class CircularArrayRotationTest : Test
    {
        private readonly CircularArrayRotationExercise _circularArrayRotationExercise = new CircularArrayRotationExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _circularArrayRotationExercise.Solve(ParseIntList("1 2 3"), 2, ParseIntList("0 1 2"));

            var expected = ParseIntList("2 3 1");
            for (var i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _circularArrayRotationExercise.Solve(ParseIntList("3 4 5"), 2, ParseIntList("1 2"));

            var expected = ParseIntList("5 3");
            for (var i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

    }
}