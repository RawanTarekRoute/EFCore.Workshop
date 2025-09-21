using Airline.Enities;
using Microsoft.EntityFrameworkCore;
using AirlineModel = Airline.Enities.Airline;

namespace Airline
{
    internal class AirlineDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-QK0IFST\\MSSQLSERVERR;Database=Airline02;Trusted_Connection=True;TrustServerCertificate =True");

        }

        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<AirlineModel> Airlines { get; set; }
        public DbSet<AirlinePhones> AirlinePhones { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeQualifications> EmployeeQualifications { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<AircraftRoute> AircraftRoutes { get; set; }



    }
}
