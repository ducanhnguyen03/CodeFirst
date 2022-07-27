using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.A_DAL.Models
{
    internal class ParkingManageContext : DbContext
    {
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<Vehicle> vehicles { get; set; }
        public ParkingManageContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-3730FF9\SQLEXPRESS;Database=Manage_Parking;Trusted_Connection=True;");
        }
    }
}
