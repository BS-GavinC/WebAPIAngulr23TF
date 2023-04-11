using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIAngulr23TF.Models;

namespace DAL.Context
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Voiture> Voitures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=WebAPIAngular23;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    }
}
