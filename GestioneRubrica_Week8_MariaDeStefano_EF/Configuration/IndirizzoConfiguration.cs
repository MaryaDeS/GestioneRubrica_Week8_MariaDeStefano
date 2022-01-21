using GestioneRubrica_Week8_MariaDeStefano_Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica_Week8_MariaDeStefano_EF.Configuration
{
    public class IndirizzoConfiguration : IEntityTypeConfiguration<Indirizzo>
    {
        public void Configure(EntityTypeBuilder<Indirizzo> builder)
        {
            builder.ToTable("Indirizzo");
            builder.HasKey(i => i.IDIndirizzo);
            builder.Property(i => i.Città).IsRequired();
            builder.Property(i => i.CAP).IsRequired();
            builder.Property(i => i.Provincia).IsRequired();
            builder.Property(i => i.Nazione).IsRequired();

            builder.HasOne(i=>i.Contatto).WithMany(i=>i.Indirizzi).HasForeignKey(i=>i.IDContatto);
            
        }
    }
}
