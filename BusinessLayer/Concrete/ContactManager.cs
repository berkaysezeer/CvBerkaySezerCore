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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public List<Contact> TGetAll(Expression<Func<Contact, bool>> where)
        {
            return _contactDal.GetAll(where);
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public void TAdd(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public List<Contact> TGetAll()
        {
            return _contactDal.GetAll();
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
