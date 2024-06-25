using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.DAL.Context
{
    public class MyPortfolioContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=OMER-PC\\SQLEXPRESS;initial Catalog=MyPortfolioDb;integrated Security=true;Trust Server Certificate =true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experince> Experinces{ get; set; }
        public DbSet<Feature> Features{ get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios{ get; set; }
        public DbSet<Skill> Skills{ get; set; }
        public DbSet<SocialMedia> SocialMedias{ get; set; }
        public DbSet<Testimonial> Testimonials{ get; set; }
        public DbSet<ToDoList> ToDoLists{ get; set; }

	}
}
