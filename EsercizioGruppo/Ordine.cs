public class Ordine : Operazione
{
    private int _clienteId;
    private string _descrizione;
    private int _quantita;
    private int _prezzoUnitario;

    public int ClienteId
    {
        get { return _clienteId; }
        set
        {
            if(value > 0)
                _clienteId = value;
        }
    }

    public string Descrizione
    {
        get { return _descrizione;}
        set
        {
            if(!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
            {
                _descrizione = value;
            }
        }
    }

    public int Quantita
    {
        get { return _quantita; }
        set
        {
            if(value > 0)
                _quantita = value;
        }
    }

    public int PrezzoUnitario
    {
        get { return _prezzoUnitario; }
        set
        {
            if(value > 0)
                _prezzoUnitario = value;
        }
    }

    
}