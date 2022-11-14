using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class QueensAttack2Test : Test
    {
        private readonly QueensAttack2Exercise _queensAttack2Exercise = new QueensAttack2Exercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _queensAttack2Exercise.Solve(4, 0, 4, 4, new List<List<int>>());

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var obstacles = new List<List<int>>
            {
                ParseIntList("5 5"),
                ParseIntList("4 2"),
                ParseIntList("2 3")
            };
            var result = _queensAttack2Exercise.Solve(5, 3, 4, 3, obstacles);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = _queensAttack2Exercise.Solve(1, 0, 1, 1, new List<List<int>>());

            Assert.AreEqual(0, result);
        }
        
        /*
        [TestMethod]
        public void TestMethod4()
        {
            var result = _queensAttack2Exercise.Solve(100000, 100000, 50000, 50000, ParseSquare(ReadFile("QueensAttack2/input14.txt")));

            Assert.AreEqual(872, result);
        }
        */

        [TestMethod]
        public void TestMethod5()
        {
            var result = _queensAttack2Exercise.Solve(3, 0, 2, 2, new List<List<int>>());

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var result = _queensAttack2Exercise.Solve(5, 0, 3, 3, new List<List<int>>());

            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var result = _queensAttack2Exercise.Solve(5, 2, 3, 3, new List<List<int>>
            {
                PlaceObstacle(4, 3),
                PlaceObstacle(4, 3)
            });

            Assert.AreEqual(14, result);
        }

        private List<int> PlaceObstacle(int row, int col)
        {
            return new List<int>
            {
                row, col
            };
        }

    }
}