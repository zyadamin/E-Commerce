using E_Commerce.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BLL.DTO
{
    public class ProductAttributesDTO
    {
        public long Id { get; set; }
        public long SizeId { get; set; }
        public long ColorId { get; set; }
        public long MaterialId { get; set; }
        public ProductSize Size { get; set; }
        public Material Material { get; set; }
        public ProductColor Color { get; set; }
    }
}
