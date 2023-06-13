using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    //Veritabanına tablolarımızı yansıttığımız sınıf
    public class Context : DbContext
    {
        //Yazılanları SQL'e birer tablo olarak yansıtır.
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ImageFile> ImageFiles { get; set; }

        public DbSet<Admin> Admins { get; set; }


    }
}
