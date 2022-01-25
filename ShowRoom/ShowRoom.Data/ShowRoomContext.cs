using Microsoft.EntityFrameworkCore;
using ShowRoom.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowRoom.Data
{
   public class ShowRoomContext : DbContext
    {
        public ShowRoomContext(DbContextOptions<ShowRoomContext> options) : base(options)
        {

        }

        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<FuelEconomy> FuelEconomy { get; set; }
        public DbSet<Wheel> Wheel { get; set; }
        public DbSet<Engine> Engine { get; set; }
        public DbSet<Car> Car { get; set; }
        public  DbSet<Bike> Bike { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Car");
            modelBuilder.Entity<Bike>().ToTable("Bike");
        }

        /*
                protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                {
                  optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=ShowRoomData");

                }
        */

    }
}
