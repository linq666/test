using Microsoft.EntityFrameworkCore;
using Sourcer;
using System.Configuration;

namespace Server.Connection
{
    public class idszContext : DbContext
    {
        public idszContext(DbContextOptions<idszContext> options) : base(options)
        {

        }
        //public virtual DbSet<Student> Student { get; set; }


        //08.13.
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////Flunt api ord_bah. 
            //modelBuilder.Entity<Student>().HasData(
            //    new Student
            //    {
            //        Id = 1,
            //        FirstName = "Lee",
            //        LastName = "John"
            //    },
            //    new Student
            //    {
            //        Id = 2,
            //        FirstName = "Lee",
            //        LastName = "YueHan"
            //    });

            // 08.13. 
            base.OnModelCreating(modelBuilder);

            //配置表模型信息
            var book = modelBuilder.Entity<Book>();
            //book.ToTable("Book").HasKey(r => r.Id);
            //book.Property(r => r.BookName).HasMaxLength(20);
            //book.Property(r => r.AuthorId).IsRequired();
            //一本书，有一个作者，外键是AuthorId，不许为空
            book.HasOne(r => r.Author).WithMany().HasForeignKey(r => r.AuthorId).IsRequired();

            var author = modelBuilder.Entity<Author>();
            author.ToTable("Author").HasKey(r => r.Id);
            author.Property(r => r.AuthorName).IsRequired();

            //SEED
   
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 101, AuthorId = 1, BookName = "Slience"   },
                new Book { Id = 102, AuthorId = 1, BookName = "Skill" },
                new Book { Id = 103, AuthorId = 2, BookName = "Scare"   }
            );

            modelBuilder.Entity<Author>().HasData(
   new Author { Id = 1, AuthorName = "East" },
   new Author { Id = 2, AuthorName = "West" }
   );


        }
    }
}
