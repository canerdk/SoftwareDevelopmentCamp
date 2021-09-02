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
            List<Product> products = productManager.GetAll();

            foreach (var p in products)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}
