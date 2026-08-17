using NUnit.Framework;

namespace NUnit_Handson
{
    [TestFixture]
    public class CalculatorTests
    {
        [SetUp]
        public void Setup() { }

        [TearDown]
        public void TearDown() { }

        // Parameterized test cases for Calculator Addition
        [TestCase(10, 20, 30)]
        [TestCase(-5, 5, 0)]
        [TestCase(0, 0, 0)]
        public void Addition_ValidInputs_ReturnsExpectedResult(int a, int b, int expected)
        {
            // Arrange & Act
            int actual = a + b; // Simulating calculator.Add(a,b)

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}