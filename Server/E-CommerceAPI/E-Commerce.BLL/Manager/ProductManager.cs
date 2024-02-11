using AutoMapper;
using E_Commerce.BLL.DTO;
using E_Commerce.BLL.Manager.Interfaces;
using E_Commerce.DAL.Entity;
using E_Commerce.DAL.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BLL.Manager
{
    public class ProductManager : IProductManager
    {
        private readonly IProductDALManager _productDALManager;
        private readonly IMapper _mapper;

        public ProductManager(IProductDALManager productDALManager, IMapper  mapper)
        {
            _productDALManager = productDALManager;
            _mapper = mapper;
        }
        public bool DeleteProduct(long productId)
        {
           return _productDALManager.DeleteProudct(productId);
        }

        public APIResponse<List<ProductDTO>> GetAllProducts()
        {
            APIResponse<List<ProductDTO>> response;
            response = new APIResponse<List<ProductDTO>>() {

                Data = _mapper.Map<List<ProductDTO>>(_productDALManager.ListAllProudcts()),
                Count = 5,
                IsSuccess = true,
                ResponseCode = HttpStatusCode.OK

        };
            return response;

        }

        public ProductDTO GetProductById(int id)
        {
            try {
                var result = _mapper.Map<ProductDTO>(_productDALManager.GetProductById(id));
                if (result == null) {

                    result = new ProductDTO();
                }
                 return result;
              }catch (Exception ex) {
                throw;
            }
                
        }

        public bool SaveProduct(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }   
        
        public bool EditProduct(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }
    }
}
