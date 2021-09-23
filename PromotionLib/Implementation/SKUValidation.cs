using PromotionLib.Interface;
using System;
using System.Text.RegularExpressions;

namespace PromotionLib.Implementation
{
    public class SKUValidation : ISKUValidation
    {
        public bool IsValidInput(string input)
        {
            Regex ex = new Regex("^\\d-\\w~*");
            bool a = ex.IsMatch(input);
            return a;
        }
    }
}
