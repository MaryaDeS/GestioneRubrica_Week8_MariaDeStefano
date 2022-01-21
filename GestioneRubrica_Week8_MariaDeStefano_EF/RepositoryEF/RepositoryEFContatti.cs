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
    public class RepositoryEFContatti : IRepositoryContatti
    {

        private readonly RubricaContext ctx;
        public RepositoryEFContatti()
        {
            ctx = new RubricaContext();
        }
        public Contatto Add(Contatto item)
        {
            ctx.Contatti.Add(item);
            ctx.SaveChanges();

            return item;
        }

        public bool Delete(Contatto contatto)
        {
            ctx.Contatti.Remove(contatto);
            ctx.SaveChanges();
            return true;
        }

        public IList<Contatto> GetAll()
        {
            return ctx.Contatti.Include(c => c.Indirizzi).ToList();
        }

        public Contatto GetByCode(int CodeContattoDaEliminare)
        {
            return ctx.Contatti.Include(i => i.Indirizzi).FirstOrDefault();
        }

        public Contatto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Contatto Update(Contatto item)
        {
            throw new NotImplementedException();
        }
    }
}
