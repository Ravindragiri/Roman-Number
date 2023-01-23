using RomanNumber.Common;
using RomanNumber.Core.Converter;
using RomanNumber.Core.Validator;

namespace RomanNumber.Core.Manager
{
    public class RomanNumberExecutor : IRomanNumberExecutor
    {
        private readonly IRomanNumberValidator _romanNumberValidator;
        private readonly IRomanNumberConverter _romanNumberConverter;

        public RomanNumberExecutor(IRomanNumberValidator romanNumberValidator,
            IRomanNumberConverter romanNumberConverter)
        {
            this._romanNumberValidator = romanNumberValidator;
            this._romanNumberConverter = romanNumberConverter;
        }

        public void Run()
        {
            Console.WriteLine("Program Number to Roman Number using below given 7 Symbols:");
            Console.WriteLine("I - 1\r\nV - 5\r\nX - 10\r\nL - 50\r\nC - 100\r\nD - 500\r\nM - 1000");
            Console.WriteLine("This Program supports numbers between 1 to 3999, because above 3999 symbols are different:\r\n");

            string response = "";
            do
            {
                Console.WriteLine("Select Command (1. To Enter Number, 2. To Exit) Pick 1-2:");
                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        ProcessNumber();
                        break;
                    case "2": break;
                    default:
                        Console.WriteLine("Please enter correct Command.\r\n");
                        break;
                }

            } while (response != "2");
        }

        /// <summary>
        /// Validate and Convert Number
        /// </summary>
        public void ProcessNumber()
        {
            Console.WriteLine("Enter Number:");
            string number = Console.ReadLine();
            bool isValidNumber = this._romanNumberValidator.ValidateNumber(number);
            if (!isValidNumber)
            {
                Console.WriteLine(
                    $"Entered Number '{number}' is Invalid. Please enter Number from {AppConstants.MIN_NUM} to {AppConstants.MAX_NUM}.\r\n");
            }
            else
            {
                var romanNumber = this._romanNumberConverter.ConvertNumberToRoman(number);
                Console.WriteLine($"Roman Number is: {romanNumber}.\r\n");
            }
        }
    }
}
