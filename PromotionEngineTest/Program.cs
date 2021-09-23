using PromotionEngineTest.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            args = new string[1];
            args[0] = "1-A|1-B|1-C";
            double totalPrice = 0;
            if(args.Length>0)
            {
                string[] skuinput = args[0].Split('|');
                foreach(string sku in skuinput)
                {
                    string[] skuPrices = sku.Split('-');
                    if (skuPrices.Length > 0)
                    {
                        int qty = Convert.ToInt32(skuPrices[0]);
                        char skuCode = Convert.ToChar(skuPrices[1]);

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

                    }
                }
            }
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

        
        
    }
}
