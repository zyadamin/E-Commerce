using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BLL.DTO
{
    public class ImageDTO
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Path { get; set; }
    }
}
