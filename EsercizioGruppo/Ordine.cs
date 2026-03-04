public class Ordine : Operazione
{
    private int clienteId;
    private string descrizione;
    private int quantita;
    private int prezzoUnitario;

    public int ClienteId
    {
        get { return clienteId; }
        set
        {
            if(value > 0)
                clienteId = value;
            else
                Console.WriteLine("Cliente ID non valido!");
        }
        
    }

    public string Descrizione
    {
        get { return descrizione;}
        set
        {
            if(!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
            {
                descrizione = value;
            }
            else
                Console.WriteLine("Descrizione non valida!");
        }
    }

    public int Quantita
    {
        get { return quantita; }
        set
        {
            if(value > 0)
                quantita = value;
            else
                Console.WriteLine("Quantità non valida!");
        }
    }

    public int PrezzoUnitario
    {
        get { return prezzoUnitario; }
        set
        {
            if(value > 0)
                prezzoUnitario = value;
            else
                Console.WriteLine("Prezzo Unitario non valido!");
        }
    }

    public override double CalcolaTotale()
    {
        return quantita * prezzoUnitario;
    }
}