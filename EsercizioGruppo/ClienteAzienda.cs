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
}