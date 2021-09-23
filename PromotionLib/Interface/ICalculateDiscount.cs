using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionLib.Interface
{
    public interface ICalculateDiscount
    {
        double GetDiscount(char skuCode, int qty);
    }
}
