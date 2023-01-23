namespace RomanNumber.Core.Converter
{
    public class RomanNumberConverter: IRomanNumberConverter
    {
        /// <summary>
        /// Convert Number to Roman Number
        /// </summary>
        /// <param name="strNumber">Input Number</param>
        /// <returns>Roman Number</returns>
        public string ConvertNumberToRoman(string strNumber)
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
    }
}
