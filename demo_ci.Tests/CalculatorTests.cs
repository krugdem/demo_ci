namespace demo_ci.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void SubZeroParameters_ThrowArgumentExeption()
        {
            Calculator calc = new Calculator();

            const int inputFirst = -1;
            const int inputSecond = -1;

            Assert.Throws<ArgumentException>(
                () => calc.Add(inputFirst, inputSecond)
            );
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(3, 1, 4)]
        [InlineData(3, 54, 57)]
        [InlineData(1, 0, 7)]
        public void InputTwoPositiveNumber_ReturnSumm(int first, int second, int result)
        {
            var calc = new Calculator();
            Assert.Equal(result, calc.Add(first, second));
        }

    }
}