using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore_WithBugs.Models
{
    public static class ProductDb
    {
        public static List<Product> GetAllProducts(ProductContext _context)
        {
            List<Product> products =
                (from prod in _context.Product
                 orderby prod.ProductName ascending
                 select prod).ToList();
            return products;
        }

        public static Product AddProduct(ProductContext context, Product prod)
        {
            context.Add(prod);
            context.SaveChanges();
            return prod;
        }
    }
}
