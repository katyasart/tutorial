using System;
using System.Collections.Generic;

namespace Food
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start!");
            Console.WriteLine();

            // Создать список продуктов
            var productList = new List<Product>();

            // Создать продукты
            var apple = new Product
            {
                Name = "Apple",
                Price = 100,
                Color = ProductColor.Green
            };
            var orange = new Product
            {
                Name = "Orange",
                Price = 150,
                Color = ProductColor.Orange
            };
            var tomato = new Product
            {
                Name = "Tomato",
                Price = 200,
                Color = ProductColor.Red
            };

            // Поместить продукты в список

            productList.Add(apple);
            productList.Add(orange);
            productList.Add(tomato);

            // Вывести н экран

            //Console.WriteLine(productList);
            ProductPresenter.PrintProducts(productList); // печать не меняя регистра
            Console.WriteLine();
            ProductPresenter.PrintProducts(productList, true); // печать в верхнем регистре

            // Подождать нажатия клавиши

            Console.ReadLine();
        }
    }
}