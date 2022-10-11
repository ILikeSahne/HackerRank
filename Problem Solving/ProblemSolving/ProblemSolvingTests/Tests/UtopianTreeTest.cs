using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class UtopianTreeTest : Test
    {
        private readonly UtopianTreeExercise _utopianTreeExercise = new UtopianTreeExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _utopianTreeExercise.Solve(5);

            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _utopianTreeExercise.Solve(4);

            Assert.AreEqual(7, result);
        }
        
    }
}