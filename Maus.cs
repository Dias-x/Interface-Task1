namespace Aufageb_1;

public class Maus : ITier
{
    
    //Eigenschaften
    public string Geschlecht { get; set; }
    public int Alter { get; set; }
    
    
    //Methoden
    public void Fressen()
    {
        Console.WriteLine($"Die Maus frisst");
    }

    public void Trinken()
    {
        Console.WriteLine($"Die Maus trinkt");
    }
}