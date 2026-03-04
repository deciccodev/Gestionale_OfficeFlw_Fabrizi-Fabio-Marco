public class TicketAssistenza : Operazione
{
    private string? priorita;
    private int oreLavoro;
    private double costoOrario;
    private Stato stato = Stato.Aperto;

    public string? Priorita
    {
        get
        {
            return priorita;
        }
        set
        {
            if(value?.ToLower() == "bassa" || value?.ToLower() == "media" || value?.ToLower() == "alta")
                priorita = value.ToLower();
            else
                Console.WriteLine("Valore non valido.");
        }
    }

    public int OreLavoro
    {
        get
        {
            return oreLavoro;
        }
        set
        {
            if(value > 0)
                oreLavoro = value;
            else
                Console.WriteLine("Numero ore non valido.");
        }
    }

    public double CostoOrario
    {
        get
        {
            return costoOrario;
        }
        set
        {
            if(value > 0)
                costoOrario = value;
            else
                Console.WriteLine("Importo costo non valido.");
        }
    }

    public Stato Stato
    {
        get
        {
            return stato;
        }
        set
        {
            if(value != Stato.Pagato)
                stato = value;
            else
                Console.WriteLine("Stato non valido.");
        }
    }

    public void Apri()
    {
        stato = Stato.Aperto;
        Console.WriteLine("Ticket aperto.");
    }

    public void Chiudi()
    {
        stato = Stato.Chiuso;
        Console.WriteLine("Ticket chiuso.");
    }

    public void Annulla()
    {
        stato = Stato.Annullato;
        Console.WriteLine("Ticket annullato.");
    }

    public override double CalcolaTotale()
    {
        if(priorita == "alta")
            return oreLavoro*costoOrario*1.25;
        return oreLavoro*costoOrario;
    }

    public override string ToCsv()
    {
        return $"{Id};{ClienteId};{Data};{priorita};{oreLavoro};{CalcolaTotale()};{stato}";
    }
}