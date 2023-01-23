using RomanNumber.Common;

namespace RomanNumber.Core.Validator
{
    public class RomanNumberValidator: IRomanNumberValidator
    {
        public bool ValidateNumber(string strNumber)
        {
            return !string.IsNullOrEmpty(strNumber) && int.TryParse(strNumber, out int iNumber) && iNumber >= AppConstants.MIN_NUM && iNumber <= AppConstants.MAX_NUM;
        }
    }
}
