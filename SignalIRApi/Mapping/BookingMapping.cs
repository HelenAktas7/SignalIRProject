using AutoMapper;
using SignalIR.DtoLayer.AboutDto;
using SignalIR.DtoLayer.BookingDto;
using SignalIR.Entity_Layer.Entities;

namespace SignalIRApi.Mapping
{
    public class BookingMapping : Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
        }
    }
}
