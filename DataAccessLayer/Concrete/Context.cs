using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<WriterUser, WriterRole, int>
    {
        //.net framework'te web.config'e bağlantı stringi yazılıyordu. Core'da web.config olmadığı için Context classına OnConfiguring ile ekliyoruz
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=localhost\\MSSQLSERVER01;database=DbCoreBerkaySezer;integrated security=true");
            optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;database=DbCoreBerkaySezer;integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceImage> ServiceImages { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Announcement> Announcements { get; set; }

    }
}
