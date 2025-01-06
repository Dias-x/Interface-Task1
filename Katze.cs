namespace Aufageb_1;

public class Katze : ITier
{
    
    //Eigenschaften
    public string Geschlecht { get; set; }
    public int Alter { get; set; }
    
    
    //Methoden
    public void Fressen()
    {
        Console.WriteLine($"Die Katze frisst");
    }

    public void Trinken()
    {
        Console.WriteLine($"Die Katze trinkt");
    }
}