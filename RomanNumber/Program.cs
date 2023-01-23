// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

Console.WriteLine("Program Number to Roman Number using below given 7 Symbols:");
Console.WriteLine("I - 1\r\nV - 5\r\nX - 10\r\nL - 50\r\nC - 100\r\nD - 500\r\nM - 1000");
Console.WriteLine("This Program supports numbers between 1 to 3999, because above 3999 symbols are different:\r\n");

const int MIN_NUM = 1;
const int MAX_NUM = 3999;

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

void ProcessNumber()
{
    Console.WriteLine("Enter Number:");
    string number = Console.ReadLine();
    bool isValidNumber = ValidateNumber(number);
    if (!isValidNumber)
    {
        Console.WriteLine($"Entered Number '{number}' is Invalid. Please enter Number from {MIN_NUM} to {MAX_NUM}.\r\n");
    }
    else
    {
        var romanNumber = ConvertNumberToRoman(number);
        Console.WriteLine($"Roman Number is: {romanNumber}.\r\n");
    }
}

bool ValidateNumber(string strNumber)
{
    return !string.IsNullOrEmpty(strNumber) && int.TryParse(strNumber, out int iNumber) && iNumber >= MIN_NUM && iNumber <= MAX_NUM;
}

string ConvertNumberToRoman(string strNumber)
{
    var number = Convert.ToInt32(strNumber);

    var th = new[] { "", "M", "MM", "MMM" };
    var h = new[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM " };
    var t = new[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
    var o = new[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

    var thousands = th[number / 1000];
    var hundreds = h[(number % 1000) / 100];
    var tens = t[(number % 100) / 10];
    var ones = o[number % 10];

    var romanNumber = (thousands + hundreds + tens + ones);

    romanNumber = romanNumber.Replace(" ", "").Trim();
    return romanNumber;

}