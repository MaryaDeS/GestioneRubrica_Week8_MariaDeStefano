using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica_Week8_MariaDeStefano_Core.Entities
{
    public class Contatto
    {
        

        public int IDContatto { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public IList<Indirizzo> Indirizzi { get; set; }=new List<Indirizzo>();

        public override string ToString()
        {
            return $"{IDContatto} - {Name} - {Surname}";
        }

    }
}
