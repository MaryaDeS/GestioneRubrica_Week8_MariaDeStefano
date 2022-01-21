using GestioneRubrica_Week8_MariaDeStefano_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica_Week8_MariaDeStefano_Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        public List<Contatto> GetAllContatti();
        public Esito AddNuovoContatto (Contatto nuovoContatto);
        public Esito RimuoviContatto(int CodeContattoDaEliminare);

        public List<Indirizzo> GetAllIndirizzi();
        public Esito AddNuovoIndirizzo(Indirizzo nuovoIndirizzo);
    }
}
