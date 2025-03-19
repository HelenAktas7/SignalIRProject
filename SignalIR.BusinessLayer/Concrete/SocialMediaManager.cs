using SignalIR.BusinessLayer.Abstract;
using SignalIR.DataAccessLayer.Abstract;
using SignalIR_EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalIR.BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialmediaDal;

        public SocialMediaManager(ISocialMediaDal serviceDal)
        {
            _socialmediaDal = serviceDal;
        }

        public void TAdd(SocialMedia entity)
        {
            _socialmediaDal.Add(entity);
        }

        public void TDelete(SocialMedia entity)
        {
            _socialmediaDal.Delete(entity);
        }

        public SocialMedia TGetById(int id)
        {
            return _socialmediaDal.GetById(id);
        }

        public List<SocialMedia> TGetListAll()
        {
            return _socialmediaDal.GetListAll();
        }

        public void TUpdate(SocialMedia entity)
        {
           _socialmediaDal.Update(entity);
        }
    }
}
