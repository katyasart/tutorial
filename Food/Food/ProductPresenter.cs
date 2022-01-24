using System;
using System.Collections.Generic;

namespace Food
{
    public static class ProductPresenter
    {
        public static void PrintProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} {product.Color} {product.Price}");
            }
        }
    }    
}

