using System;
using Aufageb_1;

class Program
{
    static void Main(string[] args)
    {
        //Objekte ertsllen
        Hund hund = new Hund();
        
        Katze katze = new Katze();
        
        Maus maus = new Maus();
        

        //Array Interface
        ITier[] tiere = new ITier[]
        {
            hund,
            katze,
            maus
        };
        
        //jedes Objekt "tier" wird ausgeführt 
        foreach (ITier tier in tiere)
        {
            Console.Write($"Geschlecht: ");
            tier.Geschlecht = Console.ReadLine();
            Console.Write($"Alter: ");
            tier.Alter = int.Parse(Console.ReadLine());
            tier.Fressen();
            tier.Trinken();
        }

    }
}