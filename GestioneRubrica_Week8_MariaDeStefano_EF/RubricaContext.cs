using GestioneRubrica_Week8_MariaDeStefano_Core.Entities;
using GestioneRubrica_Week8_MariaDeStefano_EF.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica_Week8_MariaDeStefano_EF
{
    internal class RubricaContext:DbContext
    {
        public DbSet<Indirizzo> Indirizzi { get; set; }
        public DbSet<Contatto> Contatti { get; set; }

        public RubricaContext()
        {

        }

        public RubricaContext(DbContextOptions<RubricaContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GestioneRubrica;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Contatto>(new ContattoConfiguration());
            modelBuilder.ApplyConfiguration<Indirizzo>(new IndirizzoConfiguration());
        }
    }
}
