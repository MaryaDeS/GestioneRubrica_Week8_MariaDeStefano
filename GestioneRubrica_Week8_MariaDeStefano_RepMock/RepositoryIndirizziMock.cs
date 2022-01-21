using GestioneRubrica_Week8_MariaDeStefano_Core.Entities;
using GestioneRubrica_Week8_MariaDeStefano_Core.IntefaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica_Week8_MariaDeStefano_RepMock
{
    public class RepositoryIndirizziMock : IRepositoryIndirizzi
    {
        public static List<Indirizzo> Indirizzi= new List<Indirizzo>();
        public Indirizzo Add(Indirizzo item)
        {
            if (Indirizzi.Count()==0)
            {
                item.IDIndirizzo=1;
            }
            else
            {
                item.IDIndirizzo = Indirizzi.Max(x=>x.IDIndirizzo)+1;
            }
            var contatto = RepositoryContattiMock.Contatti.FirstOrDefault(c => c.IDContatto == item.IDContatto);
            item.Contatto = contatto;

            contatto.Indirizzi.Add(item);

            Indirizzi.Add(item);
            return item;

            
            
        }

        public IList<Indirizzo> GetAll()
        {
            return Indirizzi.ToList();
        }

        public Indirizzo GetById(int id)
        {
            return GetAll().FirstOrDefault(i=>i.IDContatto==id);
        }

        

        
    }
}
