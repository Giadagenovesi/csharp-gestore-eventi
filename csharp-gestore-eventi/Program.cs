namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chiedo all'utente di inserire un titolo per il suo programma eventi
            Console.WriteLine("Inserisci il titolo del tuo programma eventi :");
            string nomeProgrammaEventi = Console.ReadLine();

            ProgrammaEventi programma1 = new ProgrammaEventi(nomeProgrammaEventi);
            int numEventi = 0;

            try
            {
                //Chiedo all'utente di inserire il numero di eventi che vuole inserire nel suo programma eventi
                Console.WriteLine("Inserisci il numero di eventi che vuoi inserire nel tuo programma:");
                int numeroEventiProgramma = int.Parse(Console.ReadLine());
                if (numeroEventiProgramma > 0 )
                {
                    numEventi = numeroEventiProgramma;
                }else
                {
                    throw new Exception("il numero di eventi deve essere maggiore di 0");
                }
            }catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            while (programma1.NumeroEventi() < numEventi)
            {
                try
                {
                    //Chiedo all'utente di inserire i dettagli degli eventi 
                    Console.WriteLine("Inserisci il nome dell'evento:");
                    string titolo = Console.ReadLine();
                    Console.WriteLine("Inserisci la data dell'evento (gg/mm/yyyy):");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci il numero di posti totali disponibili:");
                    int capienzaEvento = int.Parse(Console.ReadLine());

                    Evento evento1 = new Evento(titolo, data, capienzaEvento);
                    programma1.AggiungiEvento(evento1);
                } catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //Stampo il numero di eventi presenti nel programma con il relativo riassunto del programma
            Console.WriteLine("il numero di eventi nel programma è:" + programma1.NumeroEventi());
            Console.WriteLine("Ecco il tuo programma eventi:");
            Console.WriteLine(programma1);

            //Chiedo all'utente di inserire una data 
            Console.Write("Inserisci una data per sapere che eventi ci saranno (gg/mm/yyyy): ");
            string dataEventoUtente= Console.ReadLine();
            DateTime dataSelezionata = DateTime.Parse(dataEventoUtente);


            //Stampo tutti gli eventi che sono presenti nel programma nella data selezionata
            List<Evento> eventiInData = programma1.EventiPerData(dataSelezionata);
            ProgrammaEventi.StampaLista(eventiInData);

            //Elimino il programma
            programma1.CancellaLista();
        }
    }
}