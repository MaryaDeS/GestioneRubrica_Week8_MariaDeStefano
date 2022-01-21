using GestioneRubrica_Week8_MariaDeStefano_Core.Entities;
using GestioneRubrica_Week8_MariaDeStefano_Core.IntefaceRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica_Week8_MariaDeStefano_EF.RepositoryEF
{
    public class RepositoryEFIndirizzi : IRepositoryIndirizzi
    { 
        private readonly RubricaContext ctx;
    public RepositoryEFIndirizzi()
    {
        ctx = new RubricaContext();
    }
    
        public Indirizzo Add(Indirizzo item)
        {
            ctx.Indirizzi.Add(item);
            ctx.SaveChanges();
            return item;
        }

        public IList<Indirizzo> GetAll()
        {
            return ctx.Indirizzi.Include(c => c.Contatto).ToList();
        }

        public Indirizzo GetById(int id)
        {
            return ctx.Indirizzi.Include(x=>x.Contatto).FirstOrDefault(d=>d.IDIndirizzo==id);
        }
    }
}
