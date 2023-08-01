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
    public class ProjectManager : IProjectDal
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void Delete(Project t)
        {
            _projectDal.Delete(t);
        }

        public List<Project> GetAll()
        {
            return _projectDal.GetAll();
        }

        public List<Project> GetAll(Expression<Func<Project, bool>> where)
        {
            return _projectDal.GetAll(where);
        }

        public Project GetById(int id)
        {
            return _projectDal.GetById(id);
        }

        public void Insert(Project t)
        {
            _projectDal.Insert(t);
        }

        public void Update(Project t)
        {
            _projectDal.Update(t);
        }
    }
}
