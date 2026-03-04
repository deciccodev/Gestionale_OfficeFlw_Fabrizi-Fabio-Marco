class Operazione
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
            id = value;
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
            clienteId = value;
        }
    }

    public DateTime data
    {
        get
        {
            return data;
        }
        set
        {
            data = value;
        }
    }

    public abstract CalcolaTotale();
}