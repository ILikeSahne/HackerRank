using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class SaveThePrisonerTest : Test
    {
        private readonly SaveThePrisonerExercise _saveThePrisonerExercise = new SaveThePrisonerExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _saveThePrisonerExercise.Solve(5, 2, 1);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _saveThePrisonerExercise.Solve(5, 2, 2);

            Assert.AreEqual(3, result);
        }
        
    }
}