public class TicketAssistenza : Operazione
{
    private string? priorita;
    private int oreLavoro;
    private double costoOrario;

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

    public override double CalcolaTotale()
    {
        if(priorita == "alta")
            return oreLavoro*costoOrario*1.25;
        return oreLavoro*costoOrario;
    }

    public override string ToCsv()
    {
        return "";
    }
}