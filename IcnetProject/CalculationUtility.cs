using System.Globalization;

namespace IcnetProject
{
    /// <summary>
    /// A utility class for performing calculations.
    /// </summary>
    public class CalculationUtility
    {
        /// <summary>
        /// Calculates the sum of three double values.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <param name="c">The third number.</param>
        /// <returns>The sum of the three numbers.</returns>
        public static double GetSum(double a, double b, double c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Calculates the product of three double values.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <param name="c">The third number.</param>
        /// <returns>The product of the three numbers.</returns>
        public static double GetProduct(double a, double b, double c)
        {
            return a * b * c;
        }

        /// <summary>
        /// Calculates the sum of the first two double values divided by the third.
        /// Throws DivideByZeroException if the third value is zero.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <param name="c">The third number.</param>
        /// <returns>The result of the calculation.</returns>
        /// <exception cref="DivideByZeroException"></exception>
        public static double GetSumOfFirstTwoDividedByThird(double a, double b, double c)
        {
            if (c == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return (a + b) / c;
        }
    }
}
