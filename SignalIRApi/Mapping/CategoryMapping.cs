using AutoMapper;
using SignalIR.DtoLayer.AboutDto;
using SignalIR.DtoLayer.CategoryDto;
using SignalIR.Entity_Layer.Entities;

namespace SignalIRApi.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping() {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

        }
    }
}
