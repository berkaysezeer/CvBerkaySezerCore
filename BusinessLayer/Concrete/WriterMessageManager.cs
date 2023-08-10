using BusinessLayer.Abstract;
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
    public class WriterMessageManager : IWriterMessageService
    {
        EfWriterMessageDal _messageDal;

        public WriterMessageManager(EfWriterMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(WriterMessage t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            _messageDal.Delete(t);
        }

        public List<WriterMessage> TGetAll()
        {
            return _messageDal.GetAll();
        }

        public List<WriterMessage> TGetAll(Expression<Func<WriterMessage, bool>> where)
        {
            return _messageDal.GetAll(where);
        }

        public WriterMessage TGetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<WriterMessage> TGetReceiverMessage(string p)
        {
            return _messageDal.GetAll(x => x.Receiver == p);
        }

        public List<WriterMessage> TGetSenderMessage(string p)
        {
            return _messageDal.GetAll(x => x.Sender == p);
        }

        public void TUpdate(WriterMessage t)
        {
            _messageDal.Update(t);
        }
    }
}
