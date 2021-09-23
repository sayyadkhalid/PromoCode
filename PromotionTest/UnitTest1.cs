using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionLib.Implementation;
using PromotionLib.Interface;

namespace PromotionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateInput()
        {
            ISKUValidation sKUValidation = new SKUValidation();
            Assert.IsTrue(sKUValidation.IsValidInput("1-A"));
        }

        [TestMethod]
        public void CalculateDiscountA()
        {
            ICalculateDiscount sKUValidation = new CalculateDiscount();
            double t = sKUValidation.GetDiscount('A', 1);
            bool isTestPassed = false;
            if (t == 50)
            {
                isTestPassed = true;
            }
            Assert.IsTrue(isTestPassed);
        }

        [TestMethod]
        public void CalculateDiscountB()
        {
            ICalculateDiscount sKUValidation = new CalculateDiscount();
            double t = sKUValidation.GetDiscount('B', 1);
            bool isTestPassed = false;
            if (t == 30)
            {
                isTestPassed = true;
            }
            Assert.IsTrue(isTestPassed);
        }
    }
}
