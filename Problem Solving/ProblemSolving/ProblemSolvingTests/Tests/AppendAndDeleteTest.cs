using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class AppendAndDeleteTest : Test
    {
        private readonly AppendAndDeleteExercise _appendAndDeleteExercise = new AppendAndDeleteExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _appendAndDeleteExercise.Solve("hackerhappy", "hackerrank", 9);

            Assert.AreEqual("Yes", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _appendAndDeleteExercise.Solve("aba", "aba", 7);

            Assert.AreEqual("Yes", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = _appendAndDeleteExercise.Solve("ashley", "ash", 2);

            Assert.AreEqual("No", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = _appendAndDeleteExercise.Solve("qwerasdf", "qwerbsdf", 6);

            Assert.AreEqual("No", result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var result = _appendAndDeleteExercise.Solve("aaaaaaaaaa", "aaaaa", 7);

            Assert.AreEqual("Yes", result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var result = _appendAndDeleteExercise.Solve("y", "yu", 2);

            Assert.AreEqual("No", result);
        }
    }
}