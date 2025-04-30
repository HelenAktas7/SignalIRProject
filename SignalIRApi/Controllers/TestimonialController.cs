using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalIR.BusinessLayer.Abstract;
using SignalIR.DtoLayer.SocialMediaDto;
using SignalIR.DtoLayer.TestimonialDto;
using SignalIR_EntityLayer.Entities;

namespace SignalIRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
                Name= createTestimonialDto.Name,
                Title= createTestimonialDto.Title,
                Comment= createTestimonialDto.Comment,
                ImageUrl= createTestimonialDto.ImageUrl,
                Status= createTestimonialDto.Status
            });
            return Ok("Müsteri Yorum Bilgisi Eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _testimonialService.TGetById(id);
            _testimonialService.TDelete(values);
            return Ok("Müsteri Yorum Bilgisi silindi.");
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
                TestimonialID= updateTestimonialDto.TestimonialID,
                Title= updateTestimonialDto.Title,
                Name= updateTestimonialDto.Name,
                Comment= updateTestimonialDto.Comment,
                ImageUrl= updateTestimonialDto.ImageUrl,
               Status= updateTestimonialDto.Status
            });
            return Ok("Müsteri Yorum Bilgisi Güncellendi..");
        }
        [HttpGet]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }
    }
}
