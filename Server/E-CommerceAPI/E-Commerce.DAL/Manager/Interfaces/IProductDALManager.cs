using E_Commerce.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Manager.Interfaces
{
    public interface IProductDALManager
    {
        bool SaveProudct(Product product);
        bool UpdateProudct(Product product);
        List<Product> ListAllProudcts();
        Product GetProductById(long id);
        bool DeleteProudct(long id);

        
    }
}
