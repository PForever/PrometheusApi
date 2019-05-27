using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PrometheusData.Models;
using System;
using System.Data.Common;

namespace PrometheusData
{
    public class PrometeusContext : DbContext/*, IPrometeusContext*/
    {
        //private static string _connectionString;

        //private static DbConnection CreateDbConnection()
        //{
        //    return new SqliteConnection(_connectionString);
        //}
        //public PrometeusContext(string connectionString)
        //{
        //    _connectionString = connectionString;
        //    Database.EnsureCreated();
        //}
        public PrometeusContext(DbContextOptions<PrometeusContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Person>().HasData(
            //    new Person { Id = 1, Age = 17, Firstname = "Артём", Lastname = "Григорьев", Description = "Варфоломеевич" },
            //    new Person { Id = 2, Age = 12, Firstname = "Кирилл", Lastname = "Ватов", Description = "Дмитриевич" }
            //    );
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Person> People { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite(CreateDbConnection());
        //}

        //void IPrometeusContext.SaveChanges()
        //{
        //    base.SaveChanges();
        //}

        //void IPrometeusContext.EnsureCreated()
        //{
        //    base.Database.EnsureCreated();
        //}
    }
}
