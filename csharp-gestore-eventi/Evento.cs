using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Evento
    {
        //ATTRIBUTI
        private string titolo;
        private DateTime data;
        private int capienzaEvento;
        private int numPostiPrenotati;


        //GETTERS

        public string GetTitolo()
        { 
            return titolo; 
        }
        public DateTime GetData()
        { 
            return data; 
        }

        public int GetCapienzaEvento()
        { 
            return capienzaEvento; 
        }
        public int GetNumPostiPrenotati() 
        {
            return numPostiPrenotati;
        }

        //SETTERS

        public void SetTitolo(string titolo)
        {
            if (titolo == null) 
            {
                throw new ArgumentNullException("Devi inserire un titolo per il tuo evento");
            } else
            {
                this.titolo = titolo;
            }
        }

        public void SetData(DateTime data)
        {
            if (data < DateTime.Now)
            {
                throw new Exception("Questa non è una macchina del tempo, inserisci una data valida");
            } else
            {
                this.data = data;

            }
        }
    }
}
