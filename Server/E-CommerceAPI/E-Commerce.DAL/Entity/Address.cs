using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Entity
{
    public class Address
    {
        public long Id { get; set; }
        public int UnitNumber { get; set; }
        public string StreetName { get; set; }
        public int FloorNumber { get; set; }
        public int FlatNumber { get; set; }
        public string City { get; set; }
        public string Counrty { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}
