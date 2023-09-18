using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        //ATTRIBUTI
        private string Titolo;
        private List<Evento> eventi;

        //COSTRUTTORE
        public ProgrammaEventi(string titolo)
        {
            this.Titolo = titolo;
            this.eventi = new List<Evento>();

        }

        //METODI 
        public void AggiungiEvento (Evento evento)
        {
            this.eventi.Add(evento);
        }

       
    }
}
