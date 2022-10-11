using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Exercises
{
    [TestClass]
    public class PickingNumbersTest : Test
    {
        private readonly PickingNumbersExercise _pickingNumbersExercise = new PickingNumbersExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var input = ParseIntList("4 6 5 3 3 1");

            var result = _pickingNumbersExercise.PickingNumbers(input);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = ParseIntList("1 2 2 3 1 2");

            var result = _pickingNumbersExercise.PickingNumbers(input);

            Assert.AreEqual(5, result);
        }
    }
}