public class ClienteAzienda : Anagrafica
{
    private string ragioneSociale;
    private string partitaIva;
    private string referente;

    public string RagioneSociale
    {
        get => ragioneSociale;
        set
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
            {
                ragioneSociale = value;
            }
            else
            {
                Console.WriteLine($"Ragione sociale non valida.");
            }
        }
    }

    public string PartitaIva
    {
        get => partitaIva;
        set
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
            {
                partitaIva = value;
            }
            else
            {
                Console.WriteLine($"Partita Iva non valida.");
            }
        }
    }

    public string Referente
    {
        get => referente;
        set
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
            {
                referente = value;
            }
            else
            {
                Console.WriteLine($"Referente non valido.");
            }
        }
    }

    public static ClienteAzienda InserisciAzienda(List<Anagrafica> clienti)
    {
        ClienteAzienda azienda = new ClienteAzienda();
        Console.WriteLine($"\nInserimento cliente azienda");
        azienda.Id = clienti.Any() ? clienti.Last().Id + 1 : 1;
        Console.WriteLine($"Ragione Sociale: ");
        azienda.RagioneSociale = Console.ReadLine();
        Console.WriteLine($"Partita Iva: ");
        azienda.PartitaIva = Console.ReadLine();
        Console.WriteLine($"Referente: ");
        azienda.Referente = Console.ReadLine();
        Console.WriteLine($"Email: ");
        azienda.Email = Console.ReadLine();
        return azienda;
    }
}