using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDAL : EfEntityRepositoryBase<Product, FinalProjectContext>, IProductDAL
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (FinalProjectContext context = new FinalProjectContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.Id
                             select new ProductDetailDto
                             {
                                 Id = p.Id,
                                 ProductName = p.Name,
                                 UnitsInStock = p.UnitsInStock,
                                 CategoryName = c.Name
                             };
                return result.ToList();
            }
        }
    }
}
