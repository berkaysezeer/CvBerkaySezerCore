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
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }


        public void TAdd(UserMessage t)
        {
            _userMessageDal.Insert(t);
        }

        public void TDelete(UserMessage t)
        {
            _userMessageDal.Delete(t);
        }

        public List<UserMessage> TGetAll()
        {
            return _userMessageDal.GetAll();
        }

        public List<UserMessage> TGetAll(Expression<Func<UserMessage, bool>> where)
        {
            return TGetAll(where);
        }

        public UserMessage TGetById(int id)
        {
            return _userMessageDal.GetById(id);
        }

        public List<UserMessage> TGetUserMessages()
        {
            return _userMessageDal.GetUserMessages();
        }

        public void TUpdate(UserMessage t)
        {
            _userMessageDal.Update(t);
        }
    }
}
