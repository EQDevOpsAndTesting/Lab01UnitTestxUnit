namespace BLL
{
    /// <summary>
    /// 
    /// </summary>
    public class MathUtilities : IMathUtilities
    {
        /// <summary>
        /// Function for adding two numerical values
        /// </summary>
        /// <param name="a">Data type double</param>
        /// <param name="b">Data type double</param>
        /// <returns>Sum of two values</returns>
        public double Add(double a, double b) => a + b;

        /// <summary>
        /// Function for the subtraction of two numbers
        /// </summary>
        /// <param name="a">Data type double</param>
        /// <param name="b">Data type double</param>
        /// <returns>Subtract two numbers</returns>
        public double Subtraction(double a, double b) => a - b;

        /// <summary>
        /// Function to multiply two numbers
        /// </summary>
        /// <param name="a">Data type double</param>
        /// <param name="b">Data type double</param>
        /// <returns>Multiplication of two numbers</returns>
        public double Multiplication(double a, double b) => a * b;

        /// <summary>
        /// Function to divide two numbers
        /// </summary>
        /// <param name="a">Data type double</param>
        /// <param name="b">Data type double</param>
        /// <returns>Division of two numbers</returns>
        /// <exception cref="DivideByZeroException"></exception>
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }

        /// <summary>
        /// Function to validate if a number is even
        /// </summary>
        /// <param name="a">Data type double</param>
        /// <returns>Boolean</returns>
        public bool EvenNumber(int a)
        {
            return a % 2 == 0;
        }
    }
}
