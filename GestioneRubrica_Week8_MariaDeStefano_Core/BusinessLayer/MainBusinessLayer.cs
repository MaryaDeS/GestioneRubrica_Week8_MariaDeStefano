using GestioneRubrica_Week8_MariaDeStefano_Core.Entities;
using GestioneRubrica_Week8_MariaDeStefano_Core.IntefaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica_Week8_MariaDeStefano_Core.BusinessLayer
{
    public class MainBusinessLayer:IBusinessLayer
    {
        private readonly IRepositoryContatti contattiRepo;
        private readonly IRepositoryIndirizzi indirizziRepo;

        public MainBusinessLayer(IRepositoryContatti contatti, IRepositoryIndirizzi indirizzi)
        {
            contattiRepo = contatti;
            indirizziRepo = indirizzi;
        }

        #region Contatti
        public List<Contatto> GetAllContatti()
        {
            return contattiRepo.GetAll().ToList();
        }

        public Esito AddNuovoContatto(Contatto nuovoContatto)
        {
            //controllo se il contatto è già presente
            //non deve esistere un contatto con lo stesso nome e cognome
            var contattoEsistente=GetAllContatti().FirstOrDefault(c=>c.Name==nuovoContatto.Name && c.Surname==nuovoContatto.Surname);
            if (contattoEsistente!=null)
            {
                return new Esito { Messaggio="Contatto già esistente", IsOk=false };
            }
            contattiRepo.Add(nuovoContatto);
            return new Esito { Messaggio= "Contatto aggiunto correttamente", IsOk = true};
        }

        public Esito RimuoviContatto(int CodeContattoDaEliminare)
        {
            var contattoEsistente=contattiRepo.GetByCode(CodeContattoDaEliminare);
            if(contattoEsistente==null)
            {
                return new Esito { Messaggio = "Id non valido impossibile eliminare", IsOk = false };
            }
            contattiRepo.Delete(contattoEsistente);
            return new Esito { Messaggio= "Contatto Eliminato Correttamente", IsOk=true };
        }
        #endregion

        #region Indirizzo

        public List<Indirizzo> GetAllIndirizzi()
        {
            return indirizziRepo.GetAll().ToList();
        }
        public Esito AddNuovoIndirizzo(Indirizzo nuovoIndirizzo)
        {
            var indirizzoEsistente = GetAllIndirizzi().FirstOrDefault(i => i.Città == nuovoIndirizzo.Città && i.CAP==nuovoIndirizzo.CAP && i.Provincia==nuovoIndirizzo.Provincia);
            if (indirizzoEsistente != null)
            {
                return new Esito { Messaggio = "Indirzzo già esistente", IsOk = false };
            }
            indirizziRepo.Add(nuovoIndirizzo);
            return new Esito { Messaggio = "Contatto aggiunto correttamente", IsOk = true };
        }

        #endregion
    }
}
