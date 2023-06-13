using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstarct
{
    public interface IMessageService
    {
        List<Message> GetListInbox(string p);
        List<Message> GetListSendbox(string p);
        void MessageyAdd(Message message);

        Message GetByID(int id);

        void MessageDelete(Message message);

        void MessageUpdate(Message message);
    }
}
