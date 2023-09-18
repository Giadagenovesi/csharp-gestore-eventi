namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

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
                Console.WriteLine("Numero posti disponibili:" + (capienzaEvento - evento1.GetNumPostiPrenotati()));

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}