using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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


        //COSTRUTTORE 
        public Evento(string titolo, DateTime data, int capienzaEvento)
        {
            SetTitolo(titolo);
            SetData(data);
            numPostiPrenotati = 0;
            if(capienzaEvento < 1)
            {
                throw new Exception("il numero dei posti deve essere maggiore di 0");
            }
            else 
            {
                this.capienzaEvento = capienzaEvento;
            }

        }


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
            } else if (titolo == "")
            {
                throw new ArgumentNullException("Devi inserire un titolo per il tuo evento");

            }else
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

        //METODI

        public void PrenotaPosti(int posti)
        {
            if (numPostiPrenotati + posti > this.capienzaEvento)
            {
                throw new Exception("Non ci sono abbastanza posti disponibili, riprova prenotando meno posti!");
            }else
            {
                numPostiPrenotati = posti;
            }

            if (this.data < DateTime.Now) 
            {
                throw new Exception("Non puoi selezionare un evento già terminato");            
            } else
            {
                numPostiPrenotati = posti;

            }
        }

        public void DisdiciPosti(int posti)
        {
            if (numPostiPrenotati - posti <= 0)
            {
                throw new Exception("Stai tentando di disdire troppi posti!");
            }
            else
            {
                numPostiPrenotati -= posti;
            }

            if (this.data < DateTime.Now)
            {
                throw new Exception("Non puoi selezionare un evento già terminato");
            }
            else
            {
                numPostiPrenotati -= posti;

            }  
        }

        public override string ToString()
        {
            string suntoEvento = $"L'evento {this.titolo} in data {this.data.ToString("dd/MM/yyyy")}"; 
            return suntoEvento;
        }

    }
}
