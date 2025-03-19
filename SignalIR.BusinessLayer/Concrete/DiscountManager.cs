using SignalIR.BusinessLayer.Abstract;
using SignalIR.DataAccessLayer.Abstract;
using SignalIR.Entity_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalIR.BusinessLayer.Concrete
{
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountdal;

        public DiscountManager(IDiscountDal discountdal)
        {
            _discountdal = discountdal;
        }

        public void TAdd(Discount entity)
        {
           _discountdal.Add(entity);
        }

        public void TDelete(Discount entity)
        {
            _discountdal.Delete(entity);
        }

        public Discount TGetById(int id)
        {
            return _discountdal.GetById(id);
        }

        public List<Discount> TGetListAll()
        {
          return _discountdal.GetListAll();
        }

        public void TUpdate(Discount entity)
        {
            _discountdal.Update(entity);
        }
    }
}
