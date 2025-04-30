using AutoMapper;
using SignalIR.DtoLayer.AboutDto;
using SignalIR.DtoLayer.DiscountDto;
using SignalIR.Entity_Layer.Entities;
using SignalIR_EntityLayer.Entities;

namespace SignalIRApi.Mapping
{
    public class DiscountMapping : Profile
    {
        public DiscountMapping()
        {

            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
        }
    }
}
