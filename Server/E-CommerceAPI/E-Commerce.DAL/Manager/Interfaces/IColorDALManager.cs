using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.DAL.Entity;
namespace E_Commerce.DAL.Manager.Interfaces
{
    public interface IColorDALManager
    {

        bool Save(ProductColor productColor);
        bool Edit(ProductColor productColor);
        List<ProductColor> ListAllColors();
        List<ProductColor> ListColorsByIds(List<long> ids);
        ProductColor getColorById(long id);
        bool Delete(long id);
    }
}
