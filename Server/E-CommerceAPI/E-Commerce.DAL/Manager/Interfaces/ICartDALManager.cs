using E_Commerce.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Manager.Interfaces
{
    public interface ICartDALManager
    {
        bool Save(ShoppingCart shoppingCart);
        bool Update(ShoppingCart shoppingCart);
        bool Delete(long id);
        ShoppingCart ListByUser(long userId);
        List<ShoppingCart> List(ShoppingCart shoppingCart);

    }
}
