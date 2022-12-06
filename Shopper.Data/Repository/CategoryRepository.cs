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
    public class CategoryRepository : ICategoryRepository
    {
        public Category Add(Category entity)
        {
            using (var context = new ShopperContext())
            {
                var result = context.Categories.Add(entity);
                context.SaveChanges(); //değişikler kaydedildiğinde contextin bundan haberdar olması lazım
                return result.Entity;
            }
        }

        public Category Delete(Category entity)
        {
            using (var context = new ShopperContext())
            {
                var result = context.Categories.Remove(entity);
                context.SaveChanges();
                return result.Entity;
            }
        }

        public IEnumerable<Category> GetAll()
        {
            using (var context = new ShopperContext())
            {
                var result = context.Categories;
                return result;
            }
        }

        public Category GetbyId(int id)
        {
            using (var context = new ShopperContext())
            {
                var result = context.Categories.Find(id);;
                return result;
            }
        }

        public IEnumerable<Category> GetExp(Expression<Func<Category, bool>> predicate)
        {
            using (var context = new ShopperContext())
            {
                var result = context.Categories.Where(predicate);
                return result;
            }
        }

        public Category Update(Category entity)
        {
            using (var context = new ShopperContext())
            {
                var result = context.Categories.Update(entity);
                context.SaveChanges();
                return result.Entity;
            }
        }
    }
}
