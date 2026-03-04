public class ClientePrivato : Anagrafica
{
    private string nome;
    private string cognome;
    private string codiceFiscale;

    public string Nome
    {
        get => nome;
        set
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
            {
                nome = value;
            }
            else
            {
                Console.WriteLine($"Nome non valido.");
            }
        }
    }

    public string Cognome
    {
        get => cognome;
        set
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
            {
                cognome = value;
            }
            else
            {
                Console.WriteLine($"Cognome non valido.");
            }
        }
    }

    public string CodiceFiscale
    {
        get => codiceFiscale;
        set
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value) && value.Length == 16)
            {
                codiceFiscale = value;
            }
            else
            {
                Console.WriteLine($"Codice fiscale non valido.");
            }
        }
    }

    public static ClientePrivato InserisciPrivato(List<Anagrafica> clienti)
    {
        ClientePrivato cliente = new ClientePrivato();
        Console.WriteLine($"\nInserimento cliente privato");
        cliente.Id = clienti.Any() ? clienti.Last().Id + 1 : 1;
        Console.WriteLine($"Nome: ");
        cliente.Nome = Console.ReadLine();
        Console.WriteLine($"Cognome: ");
        cliente.Cognome = Console.ReadLine();
        Console.WriteLine($"Codice Fiscale: ");
        cliente.CodiceFiscale = Console.ReadLine();
        Console.WriteLine($"Email: ");
        cliente.Email = Console.ReadLine();
        return cliente;
    }
}