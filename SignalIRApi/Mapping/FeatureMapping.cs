using AutoMapper;
using SignalIR.DtoLayer.AboutDto;
using SignalIR.DtoLayer.FeatureDto;
using SignalIR.Entity_Layer.Entities;

namespace SignalIRApi.Mapping
{
    public class FeatureMapping : Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
        }
    }
}
