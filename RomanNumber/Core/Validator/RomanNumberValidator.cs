using RomanNumber.Common;

namespace RomanNumber.Core.Validator
{
    public class RomanNumberValidator: IRomanNumberValidator
    {
        /// <summary>
        /// Null Or Empty Check
        /// Data Type Check
        /// Range Check
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns></returns>
        public bool ValidateNumber(string strNumber)
        {
            return !string.IsNullOrEmpty(strNumber) && int.TryParse(strNumber, out int iNumber) && iNumber >= AppConstants.MIN_NUM && iNumber <= AppConstants.MAX_NUM;
        }
    }
}
