using System;
using MyWebAppApis.Services;
using MyWebAppApis.Models;
using Microsoft.AspNetCore.Mvc;
namespace MyWebAppApis.Services
{
    public class ProductsService : IProductRepo
    {
        private readonly SiteDBContext db;

        public ProductsService(SiteDBContext db)
        {
            this.db = db;
        }
        public Product AddProduct(Product product)
        {
            this.db.Products.Add(product);
            this.db.SaveChanges();
            return product;
        }

        public Product UpdateProducts(Product product)
        {
            var entity = this.db.Products.Attach(product);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.db.SaveChanges();
            return product;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = from product in this.db.Products
                           orderby product.Price ascending
                           select product;

            return products;
        }

        public Product GetProductById(int id)
        {
            return this.db.Products.Find(id);
        }

        public Product GetProductByName(string name)
        {
            var product = this.db.Products.FirstOrDefault(p => p.ProductName.Equals(name));
            return product;
        }
    }
}
