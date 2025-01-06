namespace Aufageb_1;

public class Hund : ITier
{
    
    //Eigenschaften
    public string Geschlecht { get; set; }
    public int Alter { get; set; }
    
    
    //Methoden
    public void Fressen()
    {
        Console.WriteLine($"Der Hund frisst");
    }

    public void Trinken()
    {
        Console.WriteLine($"Der Hund trinkt");
    }
}