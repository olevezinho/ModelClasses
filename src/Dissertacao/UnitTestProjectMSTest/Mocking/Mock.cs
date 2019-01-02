namespace UnitTestProjectMSTest.Mocking
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ModelClasses;
    using Moq;

    [TestClass]
    public class Mock
    {
        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(1, 1, 2)]
        public void ShouldReplaceValues(int a, int b, int sum)
        {
            //Arrange
            var sut = new Calculator { };
            var mock = new Mock<Calculator>();

            //Act
            mock.Verify();

            //Assert
            var result = sut.Add(a, b);
            Assert.AreEqual(sum, result);
        }
    }
}
