using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Exercises
{
    [TestClass]
    public class CountingValleysTest
    {
        private readonly CountingValleysExercise _countingValleysExercise = new CountingValleysExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _countingValleysExercise.CountingValleys(8, "UDDDUDUU");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _countingValleysExercise.CountingValleys(12, "DDUUDDUDUUUD");

            Assert.AreEqual(2, result);
        }
        
    }
}