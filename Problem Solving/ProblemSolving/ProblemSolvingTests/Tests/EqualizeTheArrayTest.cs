using FluentAssertions;
using ProblemSolving.Exercises;

namespace ProblemSolvingTests.Tests
{
    [TestClass]
    public class EqualizeTheArrayTest : Test
    {
        private readonly EqualizeTheArrayExercise _equalizeTheArrayExercise = new EqualizeTheArrayExercise();

        [TestMethod]
        public void TestMethod1()
        {
            var result = _equalizeTheArrayExercise.Solve(ParseIntList("3 3 2 1 3"));
            
            result.Should().Be(2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = _equalizeTheArrayExercise.Solve(ParseIntList("1 2 3 1 2 3 3 3"));
            
            result.Should().Be(4);
        }
        
    }
}