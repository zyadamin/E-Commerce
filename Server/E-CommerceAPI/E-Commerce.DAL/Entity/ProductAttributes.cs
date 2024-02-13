using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Entity
{
    public class ProductAttributes
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long SizeId { get; set; }
        public long ColorId { get; set; }
        public long MaterialId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

       public Product Product { get; set; }
       public ProductSize Size { get; set; }
       public Material Material { get; set; }
       public ProductColor Color { get; set; }


    }
}
