using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDAL());
            Product product = new Product();
            product.CategoryId = 1;
            product.Name = "deneme";
            product.UnitPrice = 15;
            product.UnitsInStock = 25;

            productManager.Add(product);
            Console.WriteLine(product);
        }
    }
}
