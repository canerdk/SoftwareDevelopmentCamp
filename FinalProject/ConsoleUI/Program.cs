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
            List<Product> products = productManager.GetAllByCategoryId(2);

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDAL());

            foreach (var p in productManager.GetProductDetails())
            {
                Console.WriteLine(p.ProductName + " " + p.CategoryName);
            }
        }
    }
}
