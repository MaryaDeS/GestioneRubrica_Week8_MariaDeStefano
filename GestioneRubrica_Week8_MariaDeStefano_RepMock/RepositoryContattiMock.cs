using GestioneRubrica_Week8_MariaDeStefano_Core.Entities;
using GestioneRubrica_Week8_MariaDeStefano_Core.IntefaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica_Week8_MariaDeStefano_RepMock
{
    public class RepositoryContattiMock : IRepositoryContatti
    {
        public static IList<Contatto> Contatti = new List<Contatto>()
        {
            new Contatto
            {
                IDContatto=1,
                Name="Mario",
                Surname="Rossi"
            },

            new Contatto
            {
                IDContatto=2,
                Name="Adelaide",
                Surname ="Del Pezzo"
            }

            
        };

        public Contatto Add(Contatto item)
        {
            if (Contatti.Count()==0)
            {
                item.IDContatto = 1;
            }
            else
            {
                item.IDContatto = Contatti.Max(x=>x.IDContatto) +1;
            }
            Contatti.Add(item);
            return item;
        }

        public bool Delete(Contatto contatto)
        {
            Contatti.Remove(contatto);
            return true;
        }

        

        public IList<Contatto> GetAll()
        {
            return Contatti.ToList();
        }

       

        public Contatto GetByCode(int CodeContattoDaEliminare)
        {
            throw new NotImplementedException();
        }

        public Contatto GetById(int id)
        {
            return GetAll().FirstOrDefault(c=>c.IDContatto==id);
        }

        public Contatto Update(Contatto contatto)
        {
            var vecchioContatto=GetByCode(contatto.IDContatto);
            vecchioContatto.Surname=contatto.Surname;
            vecchioContatto.Name=contatto.Name;
            return contatto;
        }

        
    }
}
