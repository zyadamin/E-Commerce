using E_Commerce.DAL.Context;
using E_Commerce.DAL.Entity;
using E_Commerce.DAL.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Manager
{
    internal class ColorDALManager : IColorDALManager
    {
        private readonly ECommerceContext _eCommerceContext;

        public ColorDALManager(ECommerceContext eCommerceContext)
        {
            _eCommerceContext = eCommerceContext;
        }
        public bool Delete(long id)
        {
            try{

                ProductColor productColor = _eCommerceContext.ProductColor.Find(id);
                _eCommerceContext.ProductColor.Remove(productColor);
                _eCommerceContext.SaveChanges();
                return true;
            }
            catch(Exception e) 
            { 
                return false;
            }
        }

        public bool Edit(ProductColor productColor)
        {
            try
            {
                _eCommerceContext.ProductColor.Update(productColor);
                _eCommerceContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public ProductColor getColorById(long id)
        {
            return _eCommerceContext.ProductColor.FirstOrDefault(x=>x.Id==id);
        }

        public List<ProductColor> ListAllColors()
        {
            return _eCommerceContext.ProductColor.ToList();
        }

        public List<ProductColor> ListColorsByIds(List<long> ids)
        {
            throw new NotImplementedException();
        }

        public bool Save(ProductColor productColor)
        {

            try
            {
                _eCommerceContext.ProductColor.Add(productColor);
                _eCommerceContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
