namespace UnitTestProjectXUnit.Mocking
{
    using ModelClasses;
    using Moq;
    using Xunit;

    [Collection("MockingTests")]
    public class Mock
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(1,0,1)]
        public void ShouldReplaceValues(int a, int b, int sum)
        {
            //Arrange
            var sut = new Calculator { };
            var mock = new Mock<Calculator>();

            mock.Verify();
            
            //Act
            var result = sut.Add(a, b);
            //Assert
            Assert.Equal(sum, result);
        }
    }
}
