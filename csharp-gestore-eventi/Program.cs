namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Inserisci il titolo del tuo programma eventi :");
                string nomeProgrammaEventi = Console.ReadLine();
                Console.WriteLine("Inserisciil numero di eventi che vuoi inserire nel tuo programma:");


                Console.WriteLine("Inserisci il nome dell'evento:");
                string titolo = Console.ReadLine();
                Console.WriteLine("Inserisci la data dell'evento (gg/mm/yyyy):");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci il numero di posti totali disponibili:");
                int capienzaEvento = int.Parse(Console.ReadLine());
                Console.WriteLine("Quanti posti vuoi prenotare?");
                int numPostiPrenotati = int.Parse(Console.ReadLine());

                Evento evento1 = new Evento(titolo, data, capienzaEvento);

                evento1.PrenotaPosti(numPostiPrenotati);
                Console.WriteLine("Numero di posti prenotati:" + evento1.GetNumPostiPrenotati());
                Console.WriteLine("Numero posti disponibili:" + (evento1.PostiDisponibili()));

                bool azione = true;
                while (azione)
                {
                    Console.WriteLine("Vuoi disdire dei posti(s/n)?");
                    string risposta = Console.ReadLine();

                    if (risposta == "s")
                    {
                        Console.WriteLine("Quanti posti vuoi disdire?");
                        int postiDaDisdire = int.Parse(Console.ReadLine());
                        evento1.DisdiciPosti(postiDaDisdire);
                        Console.WriteLine("Numero posti disponibili:" + (evento1.PostiDisponibili()));
                        Console.WriteLine("Numero di posti prenotati:" + evento1.GetNumPostiPrenotati());
                    }
                    else
                    {
                        break;
                    }


                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}