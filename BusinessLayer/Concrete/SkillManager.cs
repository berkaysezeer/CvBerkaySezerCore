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
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public List<Skill> TGetAll(Expression<Func<Skill, bool>> where)
        {
            return _skillDal.GetAll(where);
        }

        public Skill TGetById(int id)
        {
            return _skillDal.GetById(id);
        }

        public void TAdd(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skillDal.Delete(t);
        }

        public List<Skill> TGetAll()
        {
            return _skillDal.GetAll();
        }

        public void TUpdate(Skill t)
        {
            _skillDal.Update(t);
        }
    }
}
