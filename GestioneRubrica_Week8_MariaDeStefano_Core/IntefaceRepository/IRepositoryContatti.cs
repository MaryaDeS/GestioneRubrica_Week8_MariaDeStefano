using GestioneRubrica_Week8_MariaDeStefano_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica_Week8_MariaDeStefano_Core.IntefaceRepository
{
    public interface IRepositoryContatti:IRepository<Contatto>
    {
        public Contatto GetById(int id);
        public Contatto GetByCode(int CodeContattoDaEliminare);

        public Contatto Update(Contatto contatto);

        public bool Delete(Contatto contatto);
    }
}
