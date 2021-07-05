using System;
using Xunit;
using Moq;

namespace Session_23_Exercises.Tests {
    public class FibonacciCalculatorTests {


        [Fact]
        public void CalculateFibonacciSeries_GivenNumberIsNegative_ThrowsArgumentException() {

            //Arrange
            var fibonacciMock = new Mock<IFibonacciCalculator>();
            fibonacciMock.Setup(x => x.FibonacciSeries(-1));

            var sut = new FibonacciSeriesCalculator(fibonacciMock.Object);
            


            //Act & Assert
            Assert.Throws<ArgumentException>(() => {
                var actual = sut.CalculateFibonacci(-1);
            });
        }


        [Fact]
        public void CalculateFibonacciSeries_GivenInputIsZero_ReturnsZeroNumber() {

            //Arrange
            var fibonacciMock = new Mock<IFibonacciCalculator>();
            fibonacciMock.Setup(x => x.FibonacciSeries(0));

            var sut = new FibonacciSeriesCalculator(fibonacciMock.Object);
            var expected = 0;

            //Act
            var actual = sut.CalculateFibonacci(0);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateFibonacciSeries_LargeGivenInputIsOne_ThrowsArgumentException() {

            //Arrange
            var fibonacciMock = new Mock<IFibonacciCalculator>();
            fibonacciMock.Setup(x => x.FibonacciSeries(101));

            var sut = new FibonacciSeriesCalculator(fibonacciMock.Object);
            

            //Act & Assert
            Assert.Throws<ArgumentException>(() => {
                var actual = sut.CalculateFibonacci(101);
            });
        }


        [Fact]
        public void CalculateFibonacciSeries_GivenInputIsOne_ReturnsOne() {

            //Arrange
            var fibonacciMock = new Mock<IFibonacciCalculator>();
            fibonacciMock.Setup(x => x.FibonacciSeries(1));

            var sut = new FibonacciSeriesCalculator(fibonacciMock.Object);
            var expected = 1;

            //Act
            var actual = sut.CalculateFibonacci(1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(14, 377)]
        [InlineData(20, 6765)]
        public void CalculateFibonacciSeries_BetweenTwoAndNinetyEightInputIsOne_ReturnsCorrectFibonacci(long n, long fibonacci) {

            //Arrange
            var fibonacciMock = new Mock<IFibonacciCalculator>();
            fibonacciMock.Setup(x => x.FibonacciSeries(n));

            var sut = new FibonacciSeriesCalculator(fibonacciMock.Object);
            
            var expected = fibonacci;

            //Act
            var actual = sut.CalculateFibonacci(n);

            //Assert
            Assert.Equal(expected, actual);
        }


    }
}
