using AutoMapper;
using SignalIR.DtoLayer.AboutDto;
using SignalIR.DtoLayer.ProductDto;
using SignalIR.Entity_Layer.Entities;

namespace SignalIRApi.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
        }
    }
}
