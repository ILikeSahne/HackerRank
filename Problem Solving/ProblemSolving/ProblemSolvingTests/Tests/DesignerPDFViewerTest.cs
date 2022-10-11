using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Exercises
{
    [TestClass]
    public class DesignerPDFViewerTest : Test
    {
        private readonly DesignerPDFViewerExercise _designerPDFViewerExercise = new DesignerPDFViewerExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var input = ParseIntList("1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5");
            var result = _designerPDFViewerExercise.DesignerPdfViewer(input, "abc");

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = ParseIntList("1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 7");
            var result = _designerPDFViewerExercise.DesignerPdfViewer(input, "zaba");

            Assert.AreEqual(28, result);
        }
        
    }
}