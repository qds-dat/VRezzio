using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VRezzio.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=VRezzioData")
        {
            Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<PhotoVideo> PhotoVideos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<University>()
                .HasRequired(x => x.Account).WithMany()
                .HasForeignKey(x => x.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasRequired(x => x.Account).WithMany()
                .HasForeignKey(x => x.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(x => x.PhotoVideos)
                .WithRequired(x=>x.Student)
                .HasForeignKey(x => x.StudentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<University>()
                .HasMany(x => x.Students)
                .WithRequired(x => x.University)
                .HasForeignKey(x => x.UniversityId)
                .WillCascadeOnDelete(false);
        }
    }
}