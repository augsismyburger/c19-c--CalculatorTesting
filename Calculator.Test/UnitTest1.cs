using System;
using Xunit;

namespace Calculator.Test
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddName()
        {
            _calculator.name = "Brian";
            string thisName = _calculator.name;

            Assert.Equal(thisName, "Brian");
        }
        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int sum = _calculator.Add(53, 30);

            // We are asserting that the output should be this
            Assert.Equal(sum, 83);
        }
        [Fact]
        public void SubtractTwoIntegers()
        {
            int remainder = _calculator.Subtract(97, 40);

            Assert.Equal(remainder, 37);
        }
        [Fact]
        public void FindSquareRoot()
        {
            int root = _calculator.SquareRooter(9);

            Assert.Equal(root, 3);
        }
        [Fact]
        public void FindSquare()
        {
            int square = _calculator.Square(4);

            Assert.Equal(square, 16);
        }
        [Fact]
        public void MultiplyTwoIntegers()
        {
            int product = _calculator.Multiply(2, 2);

            Assert.Equal(product, 4);
        }
        [Fact]
        public void DivideTwoIntegers()
        {
            int qoutient = _calculator.Divide(8, 2);

            Assert.Equal(qoutient, 4);
        }
    }
    // public class UnitTest1
    // {
    //     [Fact]
    //     public void Test1()
    //     {

    //     }
    // }
}
