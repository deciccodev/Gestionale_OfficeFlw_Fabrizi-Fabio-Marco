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
}