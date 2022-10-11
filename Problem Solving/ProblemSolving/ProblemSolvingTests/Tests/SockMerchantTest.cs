using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class SockMerchantTest : Test
    {
        private readonly SockMerchantExercise _sockMerchantExercise = new SockMerchantExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var socks = ParseIntList("10 20 20 10 10 30 50 10 20");

            var result = _sockMerchantExercise.SockMerchant(socks.Count, socks);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var socks = ParseIntList("1 1 3 1 2 1 3 3 3 3");

            var result = _sockMerchantExercise.SockMerchant(socks.Count, socks);

            Assert.AreEqual(4, result);
        }
    }
}