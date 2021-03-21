namespace UnitTestProjectXUnit
{
    using ModelClasses;
    using System;
    using Xunit;

    public class UnitTestingInXUnit
    {
        [Theory]
        [InlineData(3, 1, 4)]
        [InlineData(3, 0, 3)]
        //[InlineData(int.MaxValue, 0, 2)]
        public void shouldReturnASum(int n1, int n2, int sum)
        {          
            var sut = new Calculator(); //Arrange
            var result = sut.Add(n1, n2); //Act
            Assert.Equal(sum, result); //Assert
        }

        [Theory]
        [InlineData(null, 1)]
        [InlineData(1, null)]
        public void ShouldNotAddNULL(int? n1, int? n2)
        {
            //Arrange
            var sut = new Calculator();
            //Assert                                   Act 
            Assert.Throws<ArgumentNullException>(() => sut.Add(n1, n2));
        }

        [Theory]
        [InlineData(2, 2, 0)]
        [InlineData(2, 1, 1)]
        public void ShouldReturnASubtraction(int n1, int n2, int sub)
        {
            var sut = new Calculator(); //Arrange
            var result = sut.Subtract(n1, n2); //Act
            Assert.Equal(sub, result); //Assert
        }

        [Theory]
        [InlineData(null, 1)]
        [InlineData(1, null)]
        public void ShouldNotSubtractNULL(int? n1, int? n2)
        {
            //Arrange
            var sut = new Calculator();
            //Assert                                   Act 
            Assert.Throws<ArgumentNullException>(() => sut.Subtract(n1, n2));
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 1, 3)]
        public void ShouldReturnAMultiplication(int n1, int n2, int mul)
        {
            var sut = new Calculator(); //Arrange
            var result = sut.Multiply(n1, n2); //Act
            Assert.Equal(mul, result); //Assert
        }

        [Theory]
        [InlineData(null, 1)]
        [InlineData(1, null)]
        public void ShouldNotMultiplyNULL(int? n1, int? n2)
        {
            //Arrange
            var sut = new Calculator();
            //Assert                                   Act 
            Assert.Throws<ArgumentNullException>(() => sut.Multiply(n1, n2));
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(2, 1, 2)]
        public void ShouldReturnADivision(int n1, int n2, int div)
        {
            var sut = new Calculator(); //Arrange
            var result = sut.Divide(n1, n2); //Act
            Assert.Equal(div, result); //Assert
        }

        [Theory]
        [InlineData(null, 1)]
        [InlineData(1, null)]
        public void ShouldNotDivideNULL(int? n1, int? n2)
        {
            //Arrange
            var sut = new Calculator();
            //Assert                                   Act 
            Assert.Throws<ArgumentNullException>(() => sut.Divide(n1, n2));
        }

        [Theory]
        [InlineData(null, 0)]
        [InlineData(1, 0)]
        public void ShouldNotDivideByZero(int? n1, int? n2)
        {
            //Arrange
            var sut = new Calculator();
            if (n1 == null)
                //Assert                                   Act 
                Assert.Throws<ArgumentNullException>(() => sut.Divide(n1, n2));
            else
                //Assert                                   Act 
                Assert.Throws<DivideByZeroException>(() => sut.Divide(n1, n2));
        }
    }
}
