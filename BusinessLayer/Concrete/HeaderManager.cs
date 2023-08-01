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
    public class HeaderManager : IHeaderService
    {
        IHeaderDal _headerDal;

        public HeaderManager(IHeaderDal headerDal)
        {
            _headerDal = headerDal;
        }

        public List<Header> TGetAll(Expression<Func<Header, bool>> where)
        {
            return _headerDal.GetAll(where);
        }

        public Header TGetById(int id)
        {
            return _headerDal.GetById(id);
        }

        public void TAdd(Header t)
        {
            _headerDal.Insert(t);
        }

        public void TDelete(Header t)
        {
            _headerDal.Delete(t);
        }

        public List<Header> TGetAll()
        {
            return _headerDal.GetAll();
        }

        public void TUpdate(Header t)
        {
            _headerDal.Update(t);
        }
    }
}
