using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void TAdd(Project t)
        {
            _projectDal.Insert(t);
        }

        public void TDelete(Project t)
        {
            _projectDal.Delete(t);
        }

        public List<Project> TGetAll()
        {
            return _projectDal.GetAll();
        }

        public List<Project> TGetAll(Expression<Func<Project, bool>> where)
        {
            return _projectDal.GetAll(where);
        }

        public Project TGetById(int id)
        {
            return _projectDal.GetById(id);
        }

        public void TUpdate(Project t)
        {
            _projectDal.Update(t);
        }
    }
}
