using E_Commerce.DAL.Context;
using E_Commerce.DAL.Entity;
using E_Commerce.DAL.Manager.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Manager
{
    public class CartDALManager : ICartDALManager
    {
        private readonly ECommerceContext _eCommerceContext;

        public CartDALManager(ECommerceContext eCommerceContext)
        {
            _eCommerceContext = eCommerceContext;
        }
        public bool Delete(long id)
        {
            try
            {
                ShoppingCart shoppingCart = _eCommerceContext.ShoppingCart.Find(id);
                _eCommerceContext.ShoppingCart.Remove(shoppingCart);
                _eCommerceContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<ShoppingCart> List(ShoppingCart shoppingCart)
        {
            return _eCommerceContext.ShoppingCart
                .Include(x=>x.ShoppingCartItems).ToList();
        }

        public ShoppingCart ListByUser(long userId)
        {
            return _eCommerceContext.ShoppingCart
                .Include(x => x.ShoppingCartItems)
                .FirstOrDefault(x => x.UserId == userId);
        }

        public bool Save(ShoppingCart shoppingCart)
        {
            try
            {
                shoppingCart.CreatedDate = DateTime.Now;
                _eCommerceContext.ShoppingCart.Add(shoppingCart);
                _eCommerceContext.SaveChanges();
                return true;

            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }

        public bool Update(ShoppingCart shoppingCart)
        {
            try
            {
                shoppingCart.ModifiedDate = DateTime.Now;
                _eCommerceContext.ShoppingCart.Update(shoppingCart);
                _eCommerceContext.SaveChanges();
                return true;

            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }
    }
}
