using System.Text.RegularExpressions;

public class Anagrafica
{
    private int id;
    private string email;

    public int Id
    {
        get => id;
        set
        {
            if (value > 0)
            {
                id = value;
            }
            else
            {
                Console.WriteLine($"Id non valido.");
            }
        }
    }

    public string Email
    {
        get => email;
        set
        {
            if (Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                email = value;
            }
            else
            {
                Console.WriteLine($"Email non valida.");
            }
        }
    }

    /* public virtual string ToCsvRow()
    {
        
    } */
}