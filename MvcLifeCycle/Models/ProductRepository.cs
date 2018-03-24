using MvcLifeCycle;
using MvcLifeCycle.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcLifeCycle
{
    public class ProductRepository :IProductRepository
    {
        SampleEntities dbcontext = new SampleEntities();

        
        public ProductRepository()
        {
            
        }
        public List<ProductVM> GetAll()
        {
            List<ProductVM> ListofProducts = new List<ProductVM>();
            var listofproduct = dbcontext.Products.ToList();
            foreach( var item in listofproduct)
            {
                ProductVM obj = new ProductVM();
                obj.Id = item.Id;
                obj.Name = item.Name;
                obj.Category = item.Category;
                obj.Price = (decimal)item.Price;

                ListofProducts.Add(obj);
            }
            return ListofProducts;
        }

        public void Create(ProductVM product)
        {
            Product pd = new Product();
            //pd.Id = 5;
            pd.Name = product.Name;
            pd.Category = product.Category;
            pd.Price = product.Price;
            dbcontext.Products.Add(pd);
            dbcontext.SaveChanges();

        }

        public void Update(ProductVM product)
        {
            var pd = dbcontext.Products.Find(product.Id);
            dbcontext.Entry(pd).State = EntityState.Modified;
            dbcontext.SaveChanges();
        }

        public void Delete(int Id)
        {
            var pd = dbcontext.Products.Find(Id);
            dbcontext.Products.Remove(pd);
            dbcontext.SaveChanges();
        }

        public ProductVM GetProduct(int Id)
        {
            var pd = (ProductVM)dbcontext.Products.Find(Id);
            return pd;
        }
    }
}