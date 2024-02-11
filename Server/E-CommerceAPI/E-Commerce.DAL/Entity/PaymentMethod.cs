using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Entity
{
    public class PaymentMethod
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long PaymentTypeId { get; set; }
        public string AccountNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool IsDefault { get; set; }
       


    }
}
