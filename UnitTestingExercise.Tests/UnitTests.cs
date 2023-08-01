using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(3, 3, 6, 12)]
        [InlineData(5, 6, 9, 20)]
        [InlineData(5, 5, 7, 17)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calculator = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = calculator.Add(num1, num2, num3);
            
            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 5, 4)]
        [InlineData(10, 5, 5)]
        [InlineData(9, 3, 6)]
        [InlineData(8, 5, 3)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var actual = calculator.Subtract(minuend, subtrhend); 
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 5, 15)]
        [InlineData(7, 5, 35)]
        [InlineData(6, 5, 30)]
        [InlineData(5, 9, 45)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var actual = calculator.MultiplyTest( num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 2 )]
        [InlineData(15, 5, 3)]
        [InlineData(9, 3, 4)]
        [InlineData(18, 3, 6)]
        [InlineData(10, 2, 5)]
        //Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var actual = calculator.DivideTest(num1, num2);
            //Assert
            Assert.Equal(expected, actual);



        }

    }
}
