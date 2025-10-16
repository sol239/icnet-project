namespace IcnetProject
{
    internal class Program
    {
        /// <summary>
        /// The main entry point of the program.
        /// Expects three command-line arguments, validates them, and performs calculations.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Three arguments are required: number1, number2, number3.");
                Console.WriteLine("You provided " + args.Length + " arguments.");
                return;
            }

            try
            {
                double a = InputValidator.ValidateAndParseInput(args[0]);
                double b = InputValidator.ValidateAndParseInput(args[1]);
                double c = InputValidator.ValidateAndParseInput(args[2]);

                Console.WriteLine(CalculationUtility.GetSum(a, b, c));
                Console.WriteLine(CalculationUtility.GetProduct(a, b, c));
                Console.WriteLine(CalculationUtility.GetSumOfFirstTwoDividedByThird(a, b, c));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input error: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Math error: " + ex.Message);
            }
        }
    }
}