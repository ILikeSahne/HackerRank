using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class LibraryFineTest : Test
    {
        private readonly LibraryFineExercise _libraryFineExercise = new LibraryFineExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _libraryFineExercise.Solve(14, 7, 2018, 5, 7, 2018);

            Assert.AreEqual(135, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _libraryFineExercise.Solve(9, 6, 2015, 6, 6, 2015);

            Assert.AreEqual(45, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = _libraryFineExercise.Solve(1, 1, 2001, 1, 1, 2000);

            Assert.AreEqual(10_000, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = _libraryFineExercise.Solve(1, 10, 1999, 1, 1, 2000);

            Assert.AreEqual(0, result);
        }

    }
}