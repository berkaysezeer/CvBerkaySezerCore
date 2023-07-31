﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    //IAboutDal'ı yapıdan bağımsız işlemleri yapabilmek için ekledik
    public class EfServiceImageDal : GenericRepository<ServiceImage>, IServiceImageDal
    {
    }
}
