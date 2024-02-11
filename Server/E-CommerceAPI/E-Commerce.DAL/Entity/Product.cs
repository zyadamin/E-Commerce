using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Entity
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public bool InStock { get; set; }
        public long Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set;}
        public long? CategoryId { get; set; }
        public long? ProductGenderId { get; set; }

        public ProductGender ProductGender { get; set; }
        public Category Category { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<ProductAttributes> ProductAttributes { get; set; }



    }
}
