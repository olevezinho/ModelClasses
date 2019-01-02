namespace UnitTestProjectXUnit
{
    using ModelClasses;
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
    }
}
