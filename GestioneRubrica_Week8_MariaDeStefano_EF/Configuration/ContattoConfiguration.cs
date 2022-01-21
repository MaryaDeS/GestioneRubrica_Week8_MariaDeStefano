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
    public class ContattoConfiguration:IEntityTypeConfiguration<Contatto>
    {
        public void Configure(EntityTypeBuilder<Contatto> builder)
        {
            builder.ToTable("Contatto");
            builder.HasKey(c=>c.IDContatto);
            builder.Property(c=>c.Name).IsRequired();
            builder.Property(c=>c.Surname).IsRequired();


            builder.HasMany(c => c.Indirizzi).WithOne(d => d.Contatto).HasForeignKey(d => d.IDContatto);
            
        }

       
    }
}
