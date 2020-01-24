using System;
using Xunit;

namespace ArrayTest.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void SumAddsTwoArrays()
        {
            // Arrange
            int[] array1 = new int[3] { 1, 2, 3 };
            int[] array2 = new int[3] {10, 20, 30 };

            var sut = new Calculator();

            // Act
            int[] summedArray = sut.AddArrays(array1, array2);

            // Assert
            Assert.Equal(11, summedArray[0]);
            Assert.Equal(22, summedArray[1]);
            Assert.Equal(33, summedArray[2]);

        }
    }
}
