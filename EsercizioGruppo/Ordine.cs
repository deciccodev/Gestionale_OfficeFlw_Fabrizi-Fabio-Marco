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
            else
                Console.WriteLine("Cliente ID non valido!");
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
            else
                Console.WriteLine("Descrizione non valida!");
        }
    }

    public int Quantita
    {
        get { return _quantita; }
        set
        {
            if(value > 0)
                _quantita = value;
            else
                Console.WriteLine("Quantità non valida!");
        }
    }

    public int PrezzoUnitario
    {
        get { return _prezzoUnitario; }
        set
        {
            if(value > 0)
                _prezzoUnitario = value;
            else
                Console.WriteLine("Prezzo Unitario non valido!");
        }
    }
}