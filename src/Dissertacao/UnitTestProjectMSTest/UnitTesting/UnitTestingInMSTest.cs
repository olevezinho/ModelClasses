namespace UnitTestProjectMSTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ModelClasses;

    [TestClass]
    public class UnitTestingInMSTest
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow(3, 2, 5)]
        [DataRow(1, 1, 2)]
        [DataRow(2, 0, 2)]
        //[DataRow(int.MaxValue, 0, 2)]
        public void shouldReturnASum(int n1, int n2, int sum)
        {
            var sut = new Calculator(); //Arrange
            var result = sut.Add(n1,n2); //Act
            Assert.AreEqual(sum, result); //Assert
        }

    }
}
