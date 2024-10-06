using Microsoft.EntityFrameworkCore;
using Simply_Books_BE.Models;
using Simply_Books_BE.Data;

namespace Simply_Books_BE
{
    public class SimplyBooksDbContext : DbContext 
    {
        public DbSet<Book> Books {  get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }



        public SimplyBooksDbContext(DbContextOptions<SimplyBooksDbContext> context) : base(context)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(BookData.Books);

            modelBuilder.Entity<Author>().HasData(AuthorData.Authors);

            modelBuilder.Entity<User>().HasData(UserData.Users);

        }
    }
}
