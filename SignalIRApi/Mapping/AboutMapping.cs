using AutoMapper;
using SignalIR.DtoLayer.AboutDto;
using SignalIR.Entity_Layer.Entities;

namespace SignalIRApi.Mapping
{
    public class AboutMapping : Profile
    {
        //Entitiesler ve dtoların baglndıgı yer proje referance olarak DtoLayer alındı
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About,UpdateAboutDto>().ReverseMap();
        }
    }
}
