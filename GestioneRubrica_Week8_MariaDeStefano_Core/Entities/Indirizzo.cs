using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica_Week8_MariaDeStefano_Core.Entities
{
    public class Indirizzo
    {
        public int IDIndirizzo { get; set; }
        public string Tipologia { get; set; }
        public string Via { get; set; }
        public string Città { get; set; }
        public string CAP { get; set; }
        public string Provincia { get; set; }
        public string Nazione { get; set; }

        //FK verso Contatto
        public int IDContatto { get; set; }
        public Contatto Contatto { get; set; }

        public override string ToString()
        {
            return $"Via: {Via} - Città: {Città} - CAP: {CAP} - Provincia: {Provincia} - Nazione: {Nazione}";
        }



    }
}
