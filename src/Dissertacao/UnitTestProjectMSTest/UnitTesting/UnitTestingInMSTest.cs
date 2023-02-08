namespace UnitTestProjectMSTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ModelClasses;
    using System;

    [TestClass]
    public class UnitTestingInMSTest
    {
        [DataTestMethod]
        [DataRow(3, 2, 5)]
        [DataRow(1, 1, 2)]
        [DataRow(2, 0, 2)]
        public void ShouldReturnASum(int n1, int n2, int sum)
        {
            var sut = new Calculator(); //Arrange
            var result = Calculator.Add(n1,n2); //Act
            Assert.AreEqual(sum, result); //Assert
        }
        
        [DataTestMethod]
        [DataRow(null,1)]
        [DataRow(1, null)]
        public void ShouldNotAddNULL(int? n1, int? n2)
        {
            //Arrange
            var sut = new Calculator();
            //Assert
            Assert.ThrowsException<ArgumentNullException>(() => Calculator.Subtract(n1, n2));
        }

        [DataTestMethod]
        [DataRow(3, 1, 2)]
        [DataRow(2, 1, 1)]
        public void ShouldReturnASubtraction(int n1, int n2, int sub)
        {
            var sut = new Calculator(); //Arrange
            var result = Calculator.Subtract(n1, n2); //Act
            Assert.AreEqual(sub, result); //Assert
        }

        [DataTestMethod]
        [DataRow(null, 1)]
        [DataRow(1, null)]
        public void ShouldNotSubtractNULL(int? n1, int? n2)
        {
            //Arrange
            var sut = new Calculator();
            //Assert
            Assert.ThrowsException<ArgumentNullException>(() => Calculator.Subtract(n1, n2));
        }

        [DataTestMethod]
        [DataRow(3, 1, 3)]
        [DataRow(2, 3, 6)]
        public void ShouldReturnAMultiplication(int n1, int n2, int mul)
        {
            var sut = new Calculator(); //Arrange
            var result = Calculator.Multiply(n1, n2); //Act
            Assert.AreEqual(mul, result); //Assert
        }

        [DataTestMethod]
        [DataRow(null, 1)]
        [DataRow(1, null)]
        public void ShouldNotMultiplyNULL(int? n1, int? n2)
        {
            //Arrange
            var sut = new Calculator();
            //Assert
            Assert.ThrowsException<ArgumentNullException>(() => Calculator.Multiply(n1, n2));
        }

        [DataTestMethod]
        [DataRow(3, 1, 3)]
        [DataRow(3, 3, 1)]
        [DataRow(3.0, 2.0, 1.5)]
        public void ShouldReturnADivision(double n1, double n2, double div)
        {
            var sut = new Calculator(); //Arrange
            var result = Calculator.Divide(n1, n2); //Act
            Assert.AreEqual(div, result); //Assert
        }

        [DataTestMethod]
        [DataRow(null, 1)]
        [DataRow(1, null)]
        public void ShouldNotDivideNULL(int? n1, int? n2)
        {
            //Arrange
            var sut = new Calculator();
            //Assert
            Assert.ThrowsException<ArgumentNullException>(() => Calculator.Divide(n1, n2));
        }

        [DataTestMethod]
        [DataRow(null, 0)]
        [DataRow(1, 0)]
        public void ShouldNotDivideByZero(int? n1, int? n2)
        {
            //Arrange
            var sut = new Calculator();
            if (n1 == null)
                //Assert                                   Act 
                Assert.ThrowsException<ArgumentNullException>(() => Calculator.Divide(n1, n2));
            else
                //Assert                                   Act 
                Assert.ThrowsException<DivideByZeroException>(() => Calculator.Divide(n1, n2));
        }
    }
}
