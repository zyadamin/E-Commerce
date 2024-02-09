using E_Commerce.BLL.DTO;
using E_Commerce.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BLL.Manager.Interfaces
{
    public interface IProductManager
    {
        bool SaveProduct(ProductDTO productDTO);
        bool EditProduct(ProductDTO productDTO);
        bool DeleteProduct(long productId);
        APIResponse<List<ProductDTO>> GetAllProducts();
        ProductDTO GetProductById(int id);
    }
}
