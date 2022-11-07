using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class RepeatedStringTest : Test
    {
        private readonly RepeatedStringExercise _repeatedStringExercise = new RepeatedStringExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _repeatedStringExercise.Solve("aba", 10);

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _repeatedStringExercise.Solve("a", 1000000000000);

            Assert.AreEqual(1000000000000, result);
        }
        
    }
}