﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDAL : IProductDAL
    {
        List<Product> _products;
        public InMemoryProductDAL()
        {
            _products = new List<Product>
            {
                new Product {Id = 1, Name = "Bardak", UnitPrice = 15, UnitsInStock = 15,CategoryId = 1},
                new Product {Id = 2, Name = "Kamera", UnitPrice = 15, UnitsInStock = 15,CategoryId = 2},
                new Product {Id = 3, Name = "Telefon", UnitPrice = 15, UnitsInStock = 15,CategoryId = 2}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);
            _products.Remove(productToDelete);
        }

        public List<Product> GetALL()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
            productToUpdate.Name = product.Name;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;
        }
    }
}