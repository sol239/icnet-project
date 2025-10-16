using System.Globalization;

namespace IcnetProject
{
    /// <summary>
    /// A class for validating and parsing input strings.
    /// </summary>
    public class InputValidator
    {
        /// <summary>
        /// Validates and parses the input string to a double.
        /// Throws FormatException if the input is not a valid number.
        /// </summary>
        /// <param name="input">A string argument passed to the method.</param>
        /// <returns>A double representation of the input string.</returns>
        /// <exception cref="FormatException"></exception>
        public static double ValidateAndParseInput(string input)
        {
            double number;
            try
            {
                number = Convert.ToDouble(input, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                throw new FormatException(input + " is not a valid number.");
            }
            return number;
        }
    }
}
