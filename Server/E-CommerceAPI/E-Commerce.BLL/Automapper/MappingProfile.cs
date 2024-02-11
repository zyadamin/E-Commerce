using AutoMapper;
using E_Commerce.BLL.DTO;
using E_Commerce.DAL.Entity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BLL.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<ProductAttributes, ProductAttributesDTO>().ReverseMap();
            CreateMap<Image, ImageDTO>().ReverseMap();
        }
    }
}
