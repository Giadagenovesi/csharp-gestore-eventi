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

        //aggiungo un'evento alla lista

        public void AggiungiEvento(Evento evento)
        {
            this.listaEventi.Add(evento);
        }

        public void AggiungiEvento (List<Evento> listEventi)
        {
            foreach (Evento evento in listaEventi){

                this.listaEventi.Add(evento);
            }
        }

       

        // restituisce lista di eventi in specifica data
        public List<Evento> EventiPerData (DateTime dataEvento)
        {
            List<Evento> listaEventiInData = new List<Evento>();
            foreach (Evento evento in this.listaEventi) 
            {
                if (dataEvento == evento.GetData())
                {
                    listaEventiInData.Add(evento);
                }
            }
            return listaEventiInData;
        }

        //stampa lista di eventi in console
        public static void StampaLista(List<Evento> listaEventi)
        {
            foreach (Evento evento in listaEventi)
            {
                Console.WriteLine(evento.ToString());
            }
        }

        //restituisce numero eventi presenti nel programma
        public int NumeroEventi() 
        { 
            return this.listaEventi.Count; 
        }

        //cancella la lista di eventi
        public void CancellaLista()
        { 
            this.listaEventi.Clear(); 
        }


        public override string ToString()
        {
            string message = "";
            foreach  (Evento evento in listaEventi)
            {
                message += "\t" + evento.ToString() + "\n";
            }
            return message;
        }
    }
}
