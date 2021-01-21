using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                ID = 1,
                CategoryID = 2,
                ProductName = "Masa",
                UnitPrice = 500,
                UnitsInStock = 3
            };

            Product product2 = new Product
            {
                ID = 2,
                CategoryID = 5,
                UnitsInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 3
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            productManager.Update(product2);

            Console.WriteLine(productManager.Topla(2, 3));

            productManager.Topla2(1, 4);

        }
    }
}
