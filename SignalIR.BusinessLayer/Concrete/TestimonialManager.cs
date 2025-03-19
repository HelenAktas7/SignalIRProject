using SignalIR.BusinessLayer.Abstract;
using SignalIR_EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalIR.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialService _testimonialService;
        public TestimonialManager(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public void TAdd(Testimonial entity)
        {
            _testimonialService.TAdd(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialService.TDelete(entity);
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialService.TGetById(id);
        }

        public List<Testimonial> TGetListAll()
        {
            return _testimonialService.TGetListAll();
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialService.TUpdate(entity);
        }
    }
}
