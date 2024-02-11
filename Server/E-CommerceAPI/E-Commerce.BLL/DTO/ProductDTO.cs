using E_Commerce.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BLL.DTO
{
    public class ProductDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool InStock { get; set; }
        public long Quantity { get; set; }

        public List<ImageDTO> Images { get; set; }
        public  List<ProductAttributesDTO> ProductAttributes { get; set; }
    }
}
