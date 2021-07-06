using System;
using Xunit;
using Moq;

namespace Session_23_Exercises.Tests {
    public class FibonacciCalculatorTests {


        [Fact]
        public void CalculateFibonacciSeries_GivenNumberIsNegative_ThrowsArgumentException() {

            //Arrange
            var sut = new FibonacciCalculator();
            
            //Act & Assert
            Assert.Throws<ArgumentException>(() => {
                var actual = sut.FibonacciSeries(-1);
            });
        }


        [Fact]
        public void CalculateFibonacciSeries_GivenInputIsZero_ReturnsZeroNumber() {

            //Arrange
            var sut = new FibonacciCalculator();
            var expected = 0;

            //Act
            var actual = sut.FibonacciSeries(0);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateFibonacciSeries_LargeGivenInputIsOne_ThrowsArgumentException() {

            //Arrange
            var sut = new FibonacciCalculator();
            

            //Act & Assert
            Assert.Throws<ArgumentException>(() => {
                var actual = sut.FibonacciSeries(101);
            });
        }


        [Fact]
        public void CalculateFibonacciSeries_GivenInputIsOne_ReturnsOne() {

            //Arrange
            var sut = new FibonacciCalculator();
            var expected = 1;

            //Act
            var actual = sut.FibonacciSeries(1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(14, 377)]
        [InlineData(20, 6765)]
        public void CalculateFibonacciSeries_BetweenTwoAndNinetyEightInputIsOne_ReturnsCorrectFibonacci(long n, long fibonacci) {

            //Arrange
            var sut = new FibonacciCalculator();
            
            var expected = fibonacci;

            //Act
            var actual = sut.FibonacciSeries(n);

            //Assert
            Assert.Equal(expected, actual);
        }


    }
}
