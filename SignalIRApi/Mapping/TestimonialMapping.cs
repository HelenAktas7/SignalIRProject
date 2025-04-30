using AutoMapper;
using SignalIR.DtoLayer.AboutDto;
using SignalIR.DtoLayer.TestimonialDto;
using SignalIR.Entity_Layer.Entities;
using SignalIR_EntityLayer.Entities;

namespace SignalIRApi.Mapping
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {

            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
        }
    }
}
