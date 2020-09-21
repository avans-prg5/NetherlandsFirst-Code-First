using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace AmericaSecond
{
    public class FirstAndSecondContext : DbContext
    {
        public FirstAndSecondContext(DbContextOptions<FirstAndSecondContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var NLD = new Country() { ISOCode = "NLD", Name = "The Kingdom of the Netherlands" };
            var USA = new Country() { ISOCode = "USA", Name = "The United States of America" };
            var notSoCool = new Car { Make = "Renault", Model = "Capture", LicensePlate = "1-NLD-73" };
            var uberCool = new Car { Make = "Tesla", Model = "S", LicensePlate = "C#-13-37" };
            modelBuilder.Entity<Country>().HasData(NLD);
            modelBuilder.Entity<Country>().HasData(USA);

            modelBuilder.Entity<Car>().HasData(notSoCool);
            modelBuilder.Entity<Car>().HasData(uberCool);

            #region PersonSeed
            modelBuilder.Entity<Person>().HasData(new Person {Id=3, FirstName = "Eric", LastName = "Kuijpers", BirthDate = new DateTime(1974, 4, 25), TelephoneNumber = "+311337" });
            modelBuilder.Entity<Person>().HasData(new Person {Id=4, FirstName = "Carron", LastName = "Schilders", BirthDate = new DateTime(1982, 5, 12), TelephoneNumber = "+112"});
            #endregion



        }
    }
}
