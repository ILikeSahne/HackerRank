using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class TheHurdleRaceTest : Test
    {
        private readonly TheHurdleRaceExercise _theHurdleRaceExercise = new TheHurdleRaceExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var input = ParseIntList("1 6 3 5 2");
            var result = _theHurdleRaceExercise.HurdleRace(4, input);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = ParseIntList("2 5 4 5 2");
            var result = _theHurdleRaceExercise.HurdleRace(7, input);

            Assert.AreEqual(0, result);
        }
        
    }
}