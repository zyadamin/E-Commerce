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
    public class ProductDALManager : IProductDALManager
    {
        private readonly ECommerceContext _eCommerceContext;

        public ProductDALManager(ECommerceContext eCommerceContext) {
            _eCommerceContext = eCommerceContext;
        }
        public bool DeleteProudct(long id)
        {
            try {

                Product product = _eCommerceContext.Product.Find(id);
                _eCommerceContext.Product.Remove(product);
                _eCommerceContext.SaveChanges();
                return true;

            }
            catch (Exception ex) { 
                return false;
            }

            
        }

        public Product GetProductById(long id)
        {
            return _eCommerceContext.Product.Find(id);
        }

        public List<Product> ListAllProudcts()
        {
            return _eCommerceContext.Product
                .Include(x=>x.Images)
                .Include(x=>x.ProductAttributes)
                .Include(x=>x.Category)
                .Include(x=>x.ProductGender)
                .ToList();
        }

        public bool SaveProudct(Product product)
        {
            try
            {
                product.CreatedDate = DateTime.Now;
                _eCommerceContext.Product.Add(product);
                _eCommerceContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateProudct(Product product)
        {
            try
            {
                product.ModifiedDate = DateTime.Now;
                _eCommerceContext.Product.Update(product);
                _eCommerceContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
