public abstract class Operazione
{
    private int id;
    private int clienteId;
    private DateTime data;

    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            if(value > 0)
                id = value;
            else
                Console.WriteLine("Valore id non valido.");
        }
    }

    public int ClienteId
    {
        get
        {
            return clienteId;
        }
        set
        {
            if(value > 0)
                clienteId = value;
            else
                Console.WriteLine("Valore id non valido.");
        }
    }

    public DateTime Data
    {
        get
        {
            return data;
        }
        set
        {
            if(value < DateTime.Now)
                data = value;
            else
                Console.WriteLine("Data non valida.");
        }
    }

    public abstract double CalcolaTotale();
}