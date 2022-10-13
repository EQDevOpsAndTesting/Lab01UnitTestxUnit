using BLL;

namespace BLLxUnitUniTests
{
    public  class MathUtilitiesTests
    {
        private readonly MathUtilities _mathUtilities;

        public MathUtilitiesTests()
        {
            _mathUtilities = new MathUtilities();
        }
        
        [Fact]
        public void Add_ShouldBe5_IfA2AndB3()
        {
            // Arrange. There is only one set of test data.
            const int a = 2;
            const int b = 3;
            const int r = 5;

            //Act
            var result = _mathUtilities.Add(a, b);

            //Assert
            Assert.Equal(r, result);
        }

        [Fact]
        public void Subtraction_ShouldBe2_IfA10AndB8()
        {
            // Arrange. There is only one set of test data.
            const int a = 2;
            const int b = 3;
            const int r = -1;

            //Act
            var result = _mathUtilities.Subtraction(a, b);

            //Assert
            Assert.Equal(r, result);
        }

        [Fact]
        public void Multiplication_ShouldBe40_IfA8AndB5()
        {
            // Arrange. There is only one set of test data.
            const int a = 10;
            const int b = 4;
            const int r = 40;

            //Act
            var result = _mathUtilities.Multiplication(a, b);

            //Assert
            Assert.Equal(r, result);
        }


        [Fact]
        public void Divide_ShouldBe2_IfA50AndB25()
        {
            // Arrange. There is only one set of test data.
            const int a = 50;
            const int b = 25;
            const int r = 2;
            
            //Act
            var result = _mathUtilities.Divide(a, b);

            //Assert
            Assert.Equal(r, result);
        }

        [Fact]
        public void Divide_ShouldBeDivideByZeroException_IfA50AndB0()
        {
            //Arrange. There is only one set of test data.
            const int a = 50;
            const int b = 0;
          
            //Act and Assert
            void Action()
            {
                _mathUtilities.Divide(a, b);
            }
            var divideByZeroException = Assert.Throws<DivideByZeroException>(Action);
            Assert.Equal("Attempted to divide by zero.", divideByZeroException.Message);
        }

        [Fact]
        public void EvenNumber_ShouldBeTrue_IfA2()
        {
            //Arrange. There is only one set of test data.
            const int a = 2;
       
            //When
            var result = _mathUtilities.EvenNumber(a);
            //Then
            Assert.True(result);
        }

        [Fact]
        public void EvenNumber_ShouldBeFalse_IfA7()
        {
            //Arrange. There is only one set of test data.
            const int a = 7;
           
            //When
            var result = _mathUtilities.EvenNumber(a);
            //Then
            Assert.False(result);
        }

    }
}
