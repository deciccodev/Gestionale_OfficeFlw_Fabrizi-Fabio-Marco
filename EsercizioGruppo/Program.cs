using System;
using System.Runtime.CompilerServices;

class Program
{
    static List<Anagrafica> clienti = new();

    static void Main()
    {
        bool continua = true;
        while (continua)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Inserisci cliente");
            Console.WriteLine("2. Inserisci operazione");
            Console.WriteLine("3. Lista clienti");
            Console.WriteLine("4. Lista operazioni");
            Console.WriteLine("5. Export CSV");
            Console.WriteLine("0. Esci");

            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1: InserisciCliente(); break;
                // case 2: InserisciOperazione(); break;
                case 3: ListaClienti(); break;
                // case 4: GestioneNote(); break;
                // case 5: ExportCSV(); break;
                case 0: continua = false; break;
                default: Console.WriteLine("Scelta non valida."); break;
            }
        }
    }



    public static void InserisciCliente()
    {
        Console.WriteLine($"\n Privato (P) o Azienda (A)? ");
        string tipoCliente = Console.ReadLine().ToUpper();

        switch (tipoCliente)
        {
            case "P":
                ClientePrivato clientePrivato = ClientePrivato.InserisciPrivato(clienti);
                clienti.Add(clientePrivato);
                Console.WriteLine($"Cliente Privato aggiunto correttamente. ");
                break;
            case "A":
                ClienteAzienda clienteAzienda = ClienteAzienda.InserisciAzienda(clienti);
                clienti.Add(clienteAzienda);
                Console.WriteLine($"Cliente Azienda aggiunto correttamente. ");
                break;
            default:
                Console.WriteLine($"Scelta non consentita.");
                break;
        }
    }

    public static void ListaClienti()
    {
        if (clienti.Count == 0)
        {
            Console.WriteLine($"Nessun cliente presente.");
        }

        Console.WriteLine($"=====Clienti Privati=====");
        foreach (var c in clienti)
        {
            if (c is ClientePrivato)
            {
                //da aggiornare con metodo toCSV
                Console.WriteLine(c);
            }
        }

        Console.WriteLine($"=====Clienti Azienda=====");
        foreach (var c in clienti)
        {
            if (c is ClienteAzienda)
            {
                //da aggiornare con metodo toCSV
                Console.WriteLine(c);
            }
        }
    }
}