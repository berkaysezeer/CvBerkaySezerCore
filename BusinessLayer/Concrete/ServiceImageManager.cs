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
    public class ServiceImageManager : IServiceImageService
    {
        IServiceImageDal _serviceImageDal;

        public ServiceImageManager(IServiceImageDal serviceImageDal)
        {
            _serviceImageDal = serviceImageDal;
        }

        public List<ServiceImage> GetAll(Expression<Func<ServiceImage, bool>> where)
        {
            return _serviceImageDal.GetAll(where);
        }

        public ServiceImage GetById(int id)
        {
            return _serviceImageDal.GetById(id);
        }

        public void TAdd(ServiceImage t)
        {
            _serviceImageDal.Insert(t);
        }

        public void TDelete(ServiceImage t)
        {
            _serviceImageDal.Delete(t);
        }

        public List<ServiceImage> TGetAll()
        {
            return _serviceImageDal.GetAll();
        }

        public void TUpdate(ServiceImage t)
        {
            _serviceImageDal.Update(t);
        }
    }
}
