using PromotionEngineTest.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PromotionLib.Interface;
using PromotionLib.Implementation;

namespace PromotionEngineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ISKUValidation validation = new SKUValidation();
            ICalculateDiscount calculateDiscount = new CalculateDiscount();
            args = new string[1];
            args[0] = "1-A~1-B~1-C";

            double totalPrice = 0;
            if(args.Length>0)
            {
                if (validation.IsValidInput(args[0]))
                {
                    string[] skuinput = args[0].Split('~');
                    foreach (string sku in skuinput)
                    {
                        string[] skuPrices = sku.Split('-');
                        if (skuPrices.Length > 0)
                        {
                            int qty = Convert.ToInt32(skuPrices[0]);
                            char skuCode = Convert.ToChar(skuPrices[1]);

                            totalPrice += calculateDiscount.GetDiscount(skuCode, qty);

                        }
                    }
                }
                else
                    Console.WriteLine("Invalid input");
            }
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

        
        
    }
}
