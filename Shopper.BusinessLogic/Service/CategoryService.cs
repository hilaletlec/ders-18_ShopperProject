using Shopper.BusinessLogic.Interface;
using Shopper.Data.Interface;
using Shopper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shopper.BusinessLogic.Service
{
    public class CategoryService : ICategoryService
    {
        //new yerine dependency injection yöntemi ile program.cs de bunları işaretlicez
        private readonly ICategoryRepository _categoryRepository; //getir götür işleri yapacak gizli olacak
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category Add(Category entity)
        {
            return _categoryRepository.Add(entity);
        }

        public Category Delete(Category entity)
        {
            return _categoryRepository.Delete(entity);
        }

        public Category Get(int id)
        {
            return _categoryRepository.GetbyId(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public IEnumerable<Category> GetExp(Expression<Func<Category, bool>> predicate)
        {
            return _categoryRepository.GetExp(predicate);
        }

        public Category Update(Category entity)
        {
            return _categoryRepository.Update(entity);
        }
    }
}
