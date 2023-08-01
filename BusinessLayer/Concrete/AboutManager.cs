﻿using BusinessLayer.Abstract;
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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public List<About> GetAll(Expression<Func<About, bool>> where)
        {
            return _aboutDal.GetAll(where);
        }

        public About GetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public List<About> TGetAll()
        {
            return _aboutDal.GetAll();
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
