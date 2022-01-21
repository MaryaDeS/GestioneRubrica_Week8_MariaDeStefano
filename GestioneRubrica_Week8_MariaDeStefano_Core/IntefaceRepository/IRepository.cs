using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica_Week8_MariaDeStefano_Core.IntefaceRepository
{
    public interface IRepository<T>
    {
        public IList<T> GetAll();
        public T Add(T item);
        
        

    }
}
