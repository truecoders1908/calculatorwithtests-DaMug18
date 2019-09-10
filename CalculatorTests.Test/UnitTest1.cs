using CalculatorTest;
using System;
using Xunit;

namespace CalculatorTests.Test
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(3, 5, 8)]
        [InlineData(6, 4, 10)]
        [InlineData(8, 6, 14)]
        [InlineData(7, 2, 9)]
        public void Adding(int num1, int num2, int num3)
        {
            Calculator challenger = new Calculator();
            int actual = challenger.Adding(num1, num2);
            Assert.Equal(num3, actual);
        }


         [Theory]
        [InlineData(3, 5, -2)]
        [InlineData(6, 4, 2)]
        [InlineData(8, 6, 2)]
        [InlineData(7, 2, 5)]

        public void Subtracting (int num1, int num2, int num3)
        {
            Calculator challenger = new Calculator();
            int actual = challenger.Subtracting(num1, num2);
            Assert.Equal(num3, actual);
        }

        [Theory]
        [InlineData(3, 5, 15)]
        [InlineData(6, 4, 24)]
        [InlineData(8, 6, 48)]
        [InlineData(7, 2, 14)]

        public void Multiplying (int num1, int num2, int num3)
        {
            Calculator challenger = new Calculator();
            int actual = challenger.Multiplying(num1, num2);
            Assert.Equal(num3, actual);
        }

        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(12, 4, 3)]
        [InlineData(20, 5, 4)]
        [InlineData(120, 20, 6)]

        public void Dividing (int num1, int num2, int num3)
        {
            Calculator challenger = new Calculator();
            int actual = challenger.Dividing(num1, num2);
            Assert.Equal(num3, actual);
        }

        [Theory]
        [InlineData(3, 6)]
        [InlineData(9, 368880)]
        [InlineData(8, 40320)]
        [InlineData(7, 5040)]

        public void Factorial (int num1, int num2)
        {
            Calculator challenger = new Calculator();
            int actual = challenger.Factorial(num1);
            Assert.Equal(num2, actual);
        }



    }
    
       
}
