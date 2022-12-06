using Shopper.Data.Interface;
using Shopper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shopper.Data.Repository
{
    public class ProductImageRepository : IProductImageRepository
    {
        public ProductImage Add(ProductImage entity)
        {
            using (var context = new ShopperContext())
            {
                var result = context.ProductImages.Add(entity);
                context.SaveChanges(); //değişikler kaydedildiğinde contextin bundan haberdar olması lazım
                return result.Entity;
            }
        }

        public ProductImage Delete(ProductImage entity)
        {
            using (var context = new ShopperContext())
            {
                var result = context.ProductImages.Remove(entity);
                context.SaveChanges();
                return result.Entity;
            }
        }

        public IEnumerable<ProductImage> GetAll()
        {
            using (var context = new ShopperContext())
            {
                var result = context.ProductImages;
                return result;
            }
        }

        public ProductImage GetbyId(int id)
        {
            using (var context = new ShopperContext())
            {
                var result = context.ProductImages.Find(id); ;
                return result;
            }
        }

        public IEnumerable<ProductImage> GetExp(Expression<Func<ProductImage, bool>> predicate)
        {
            using (var context = new ShopperContext())
            {
                var result = context.ProductImages.Where(predicate);
                return result;
            }
        }

        public ProductImage Update(ProductImage entity)
        {
            using (var context = new ShopperContext())
            {
                var result = context.ProductImages.Update(entity);
                context.SaveChanges();
                return result.Entity;
            }
        }
    }
}
