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
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public List<Service> GetAll(Expression<Func<Service, bool>> where)
        {
            return _serviceDal.GetAll(where);
        }

        public Service GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public void TAdd(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public List<Service> TGetAll()
        {
            return _serviceDal.GetAll();
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
