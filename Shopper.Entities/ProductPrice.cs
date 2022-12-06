using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper.Entities
{
    public class ProductPrice
    {
        public int PriceId { get; set; }
        public UnitPrice UnitPrice { get; set; }
        public int ProductId { get; set; }  //foreign key
        public decimal Price { get; set; }
        public bool isValidFlag { get; set; }

        public Product Product { get; set; }  //1 tane ürüne ait olduğunu gösteriyoruz
    }

    public enum UnitPrice
    {
        Dolar,
        Lira,
        Euro
    }
}
