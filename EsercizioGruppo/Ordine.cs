public class Ordine : Operazione
{
    private int clienteId;
    private string descrizione;
    private int quantita;
    private decimal prezzoUnitario;
    private Stato statoCorrente = Stato.Aperto;

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

    public decimal PrezzoUnitario
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

    public Stato StatoCorrente
    {
        get => statoCorrente;
        private set
        {
            statoCorrente = value;
        }
    }

    public override double CalcolaTotale()
    {
        return (double)(quantita * prezzoUnitario);
    }

    public void PagaOrdine()
    {
        if (StatoCorrente != Stato.Aperto)
        {
            Console.WriteLine($"Impossibile pagare ordine in questo stato: {StatoCorrente}");
            return;
        }

        Console.WriteLine("Ordine pagato con successo!");
        StatoCorrente = Stato.Pagato;
    }

    public void AnnullaOrdine()
    {
        if (StatoCorrente == Stato.Chiuso)
        {
            Console.WriteLine("Un ordine chiuso non può essere annullato.");
            return;
        }

        Console.WriteLine("Ordine annullato con successo!");
        StatoCorrente = Stato.Annullato;
    }

    public override string ToCsv()
    {
        return "";
    }
}