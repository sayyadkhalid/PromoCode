using PromotionLib.Enum;
using PromotionLib.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionLib.Implementation
{
    public class CalculateDiscount : ICalculateDiscount
    {
        public double GetDiscount(char skuCode, int qty)
        {
            double totalPrice = 0;
            switch (skuCode)
            {
                case 'A':
                    if (qty >= 3)
                    {
                        int discountedQty = qty / 3;
                        int undiscountedQty = qty % 3;
                        totalPrice += 130 * discountedQty;
                        totalPrice += Convert.ToDouble(SKUPrices.A) * undiscountedQty;
                    }
                    else
                    {
                        totalPrice += Convert.ToDouble(SKUPrices.A) * qty;
                    }
                    break;
                case 'B':
                    if (qty >= 2)
                    {
                        int discountedQty = qty / 2;
                        int undiscountedQty = qty % 2;
                        totalPrice += 45 * discountedQty;
                        totalPrice += Convert.ToDouble(SKUPrices.B) * undiscountedQty;
                    }
                    else
                    {
                        totalPrice += Convert.ToDouble(SKUPrices.B) * qty;
                    }
                    break;
                case 'C':
                    totalPrice += Convert.ToDouble(SKUPrices.C) * qty;
                    break;
                case 'D':
                    totalPrice += Convert.ToDouble(SKUPrices.D) * qty;
                    break;
            }
            return totalPrice;
        }
    }
}
