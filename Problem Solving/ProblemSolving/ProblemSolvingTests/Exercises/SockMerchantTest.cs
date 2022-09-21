using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Exercises
{
    [TestClass]
    public class SockMerchantTest
    {
        private readonly SockMerchantExercise _sockMerchantExercise = new SockMerchantExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var socks = Parse("10 20 20 10 10 30 50 10 20");

            var result = _sockMerchantExercise.SockMerchant(socks.Count, socks);

            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var socks = Parse("1 1 3 1 2 1 3 3 3 3");

            var result = _sockMerchantExercise.SockMerchant(socks.Count, socks);

            Assert.AreEqual(result, 4);
        }

        private List<int> Parse(string s)
        {
            return s.Split(' ').Select(int.Parse).ToList();
        }
    }
}