using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MyHousing.Models;

namespace MyHousing.DAL
{
    public class MyHousingContext : DbContext
    {
        public MyHousingContext()
            : base("name=MyHousingContext")
        {
        }

        public DbSet<HouseState> HouseStates { get; set; }
        public DbSet<RentCase> RentCases { get; set; }
        public DbSet<HousePicture> HousePictures { get; set; }
        // public DbSet<SearchOption> SearchOptions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}