using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class DrawingBookTest : Test
    {
        private readonly DrawingBookExercise _drawingBookExercise = new DrawingBookExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _drawingBookExercise.PageCount(6, 2);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _drawingBookExercise.PageCount(5, 4);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = _drawingBookExercise.PageCount(5, 3);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = _drawingBookExercise.PageCount(6, 5);

            Assert.AreEqual(1, result);
        }
    }
}