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
    public class ProductImageService : IProductImageService
    {
        private readonly IProductImageRepository _productImageRepository; //getir götür işleri yapacak gizli olacak
        public ProductImageService(IProductImageRepository productImageRepository)
        {
            _productImageRepository = productImageRepository;
        }

        public ProductImage Add(ProductImage entity)
        {
            return _productImageRepository.Add(entity);
        }

        public ProductImage Delete(ProductImage entity)
        {
            return _productImageRepository.Delete(entity);
        }

        public ProductImage Get(int id)
        {
            return _productImageRepository.GetbyId(id);
        }

        public IEnumerable<ProductImage> GetAll()
        {
            return _productImageRepository.GetAll();
        }

        public IEnumerable<ProductImage> GetExp(Expression<Func<ProductImage, bool>> predicate)
        {
            return _productImageRepository.GetExp(predicate);
        }

        public ProductImage Update(ProductImage entity)
        {
            return _productImageRepository.Update(entity);
        }
    }
}
