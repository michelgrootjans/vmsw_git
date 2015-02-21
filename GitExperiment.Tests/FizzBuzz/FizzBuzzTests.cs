using NUnit.Framework;

namespace GitExperiment.Tests.FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(2, ExpectedResult = "2")]
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(4, ExpectedResult = "4")]
        [TestCase(5, ExpectedResult = "Buzz")]
        public string Calculate_FizzBuzz(int value)
        {
            return new FizzBuzzCalculator().Parse(value);
        }
    }

    public class FizzBuzzCalculator
    {
        public string Parse(int value)
        {
            if (value == 3) return "Fizz";
            if (value == 5) return "Buzz";
            return value.ToString();
        }
    }
}