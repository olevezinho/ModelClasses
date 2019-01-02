namespace UnitTestProjectNUnit
{
    using ModelClasses;
    using NUnit.Framework;
    using System;

    public class UnitTestingNUnit
    {
        [Test]
        [TestCase(3, 1, 4)]
        [TestCase(2, 1, 3)]
        //[TestCase(int.MaxValue, 0, 2)]
        public void shouldReturnASum(int n1, int n2, int sum)
        {
            var sut = new Calculator(); //Arrange
            var result = sut.Add(n1,n2); //Act
            Assert.AreEqual(sum, result); //Assert
        }

        [Test]
        [TestCase(null, 1)]
        [TestCase(1 ,null)]
        public void ShouldNotAddNULL(int? n1, int? n2)
        {
            //Arrange
            var sut = new Calculator();
            //Assert
            Assert.Throws<ArgumentNullException>(() => sut.Add(n1, n2));
        }
    }
}
