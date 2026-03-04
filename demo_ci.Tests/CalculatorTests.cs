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
    }
}