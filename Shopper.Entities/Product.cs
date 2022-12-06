using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }  //foreign key

        public Category ProductCategory { get; set; }  //1 ürün 1 kategoriye ait
        public ICollection<ProductPrice> ProductPrice { get; set; } //1den fazla fiyat olacak 1 tanesini seçecek - isValidFlag ile
        public ICollection<ProductImage> ProductImage { get; set; } //1 ürünün 1den fazla resmi olacak
    }
}
