using Shopper.BusinessLogic.Interface;
using Shopper.Data.Interface;
using Shopper.Data.Repository;
using Shopper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shopper.BusinessLogic.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository; //getir götür işleri yapacak gizli olacak
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public Product Add(Product entity)
        {
            return _productRepository.Add(entity);
        }

        public Product Delete(Product entity)
        {
            return _productRepository.Delete(entity);
        }

        public Product Get(int id)
        {
            return _productRepository.GetbyId(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public IEnumerable<Product> GetExp(Expression<Func<Product, bool>> predicate)
        {
            return _productRepository.GetExp(predicate);
        }

        public Product Update(Product entity)
        {
            return _productRepository.Update(entity);
        }

    }
}
