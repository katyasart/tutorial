using System;
using System.Collections.Generic;

namespace Food
{
    public static class ProductPresenter
    {
        public static void PrintProducts(List<Product> products, bool isUpper = false)
        {
            foreach (var product in products)
            {
                var s = $"{product.Name} | {product.Color} | {product.Price}";
                if (isUpper == true)
                {
                    s = s.ToUpper();
                }
                
                Console.WriteLine(s);
            }
        }
    }
}