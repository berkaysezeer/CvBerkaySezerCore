using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialDal;

        public SocialMediaManager(ISocialMediaDal socialDal)
        {
            _socialDal = socialDal;
        }

        public List<SocialMedia> TGetAll(Expression<Func<SocialMedia, bool>> where)
        {
            return _socialDal.GetAll(where);
        }

        public SocialMedia TGetById(int id)
        {
            return _socialDal.GetById(id);
        }

        public void TAdd(SocialMedia t)
        {
            _socialDal.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _socialDal.Delete(t);
        }

        public List<SocialMedia> TGetAll()
        {
            return _socialDal.GetAll();
        }

        public void TUpdate(SocialMedia t)
        {
            _socialDal.Update(t);
        }
    }
}
