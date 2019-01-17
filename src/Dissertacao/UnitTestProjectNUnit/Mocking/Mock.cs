namespace UnitTestProjectNUnit.Mocking
{
    using NUnit.Framework;
    using Moq;
    using ModelClasses;

    public class Mock
    {
        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        public void ShouldReplaceValues(int a, int b, int sum)
        {
            //Arrange
            var sut = new Calculator { };
            var mock = new Mock<Calculator>();

            //Act
            mock.Verify();

            //Assert
            var result = sut.Add(a,b);
            Assert.AreEqual(sum, result);           
        }
    }
}
