using GestioneRubrica_Week8_MariaDeStefano_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica_Week8_MariaDeStefano_Core.IntefaceRepository
{
    public interface IRepositoryIndirizzi:IRepository<Indirizzo>
    {
        public Indirizzo GetById(int id);
       
    }
}
