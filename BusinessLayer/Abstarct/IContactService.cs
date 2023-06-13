using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstarct
{
    public interface IContactService
    {
        List<Contact> GetList();
        void AddContact(Contact contact);

        Contact GetByID(int id);

        void ContactDelete(Contact contact);

        void ContactUpdate(Contact contact);
    }
}
