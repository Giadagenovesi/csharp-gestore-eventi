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
        public string Titolo { get; private set;}
        public List<Evento> listaEventi { get; private set;}

        //COSTRUTTORE
        public ProgrammaEventi(string titolo)
        {
            this.Titolo = titolo;
            this.listaEventi = new List<Evento>();

        }

        //METODI 
        public void AggiungiEvento (Evento evento)
        {
            this.listaEventi.Add(evento);
        }

        public void EventiPerData (DateTime dataEvento)
        {
            List<Evento> listaEventiInData = new List<Evento>();
            foreach (Evento evento in this.listaEventi) 
            {
                if (dataEvento == evento.GetData())
                {
                    listaEventiInData.Add(evento);
                }
            }

        }

        public static void StampaLista(List<Evento> listaEventi)
        {
            foreach (Evento evento in listaEventi)
            {
                Console.WriteLine(evento.ToString());
            }
        }

        public int NumeroEventi() 
        { 
            return this.listaEventi.Count; 
        }

        public void CancellaLista()
        { 
            this.listaEventi.Clear(); 
        }

        public override string ToString()
        {
            string message = "";
            foreach  (Evento evento in listaEventi)
            {
                message += evento.ToString();
            }
            return message;
        }
    }
}
