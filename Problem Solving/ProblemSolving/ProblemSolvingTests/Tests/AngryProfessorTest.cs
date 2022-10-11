using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class AngryProfessorTest : Test
    {
        private readonly AngryProfessorExercise _angryProfessorExercise = new AngryProfessorExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _angryProfessorExercise.Solve(3, ParseIntList("-1 -3 4 2"));

            Assert.AreEqual("YES", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _angryProfessorExercise.Solve(2, ParseIntList("0 -1 2 1"));

            Assert.AreEqual("NO", result);
        }
        
    }
}