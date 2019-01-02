namespace UnitTestProjectMSTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ModelClasses;
    using System;

    [TestClass]
    public class UnitTestingInMSTest
    {
        [TestMethod]
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
        
        [TestMethod]
        [DataRow(null,1)]
        [DataRow(1, null)]
        public void ShouldNotAddNULL(int? n1, int? n2)
        {
            //Arrange
            var sut = new Calculator();
            Exception exception = null;
            //Act
            try
            {
                int sum = sut.Add(n1,n2);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            //Assert
            Assert.IsNotNull(exception);
        }
    }
}
