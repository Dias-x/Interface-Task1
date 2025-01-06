namespace Aufageb_1;

public interface ITier
{
    
    //Eigenschaften
    string Geschlecht { get; set; }
    int Alter { get; set; }
    
    
    //Methoden
    void Fressen();
    void Trinken();
}