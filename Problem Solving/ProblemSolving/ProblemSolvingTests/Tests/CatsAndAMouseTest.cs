using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class CatsAndAMouseTest : Test
    {
        private readonly CatsAndAMouseExercise _catsAndAMouseExercise = new CatsAndAMouseExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _catsAndAMouseExercise.CatAndMouse(1, 2, 3);

            Assert.AreEqual("Cat B", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _catsAndAMouseExercise.CatAndMouse(1, 3, 2);

            Assert.AreEqual("Mouse C", result);
        }
        
    }
}