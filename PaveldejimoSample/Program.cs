using PaveldejimoSample.Models;
using System;

namespace PaveldejimoSample;

public class Program
{
    public static void Main(string[] args)
    {
        Direktorius direktorius = new Direktorius("Jonas", "Jonaitis", 39510100532, "10:00", "14:00");
        
        Vadybininkas vadybininkas1 = new Vadybininkas("Vilius", "Vadybininkaitis", 3910101543, new List<string> { "Projektas A", "Projektas B"});
        Vadybininkas vadybininkas2 = new Vadybininkas("Petras", "Vadybininkaitis", 3910101543, new List<string> { "Projektas 123", "Projektas 1243", "Projektas 12345" });

        SandelioDarbuotojas sandelioDarbuotojas1 = new SandelioDarbuotojas("Vardaitis", "Pavardaitis", 39730816123, 3200);
        SandelioDarbuotojas sandelioDarbuotojas2 = new SandelioDarbuotojas("Jonaitis", "Pavardaitis", 39730816321, 5200);
        SandelioDarbuotojas sandelioDarbuotojas3 = new SandelioDarbuotojas("Romaitis", "Pavardaitis", 39730801444, 7543);

        List<Darbuotojas> imonesDarbuotojai = new List<Darbuotojas>();

        imonesDarbuotojai.Add(direktorius);
        imonesDarbuotojai.Add(vadybininkas1);
        imonesDarbuotojai.Add(vadybininkas2);
        imonesDarbuotojai.Add(sandelioDarbuotojas1);
        imonesDarbuotojai.Add(sandelioDarbuotojas2);
        imonesDarbuotojai.Add(sandelioDarbuotojas3);

        foreach(Darbuotojas d in imonesDarbuotojai)
        {
            if(d is Direktorius)
                Console.WriteLine(((Direktorius)d).DarboLaikoPradzia);
            else if(d is Vadybininkas)
                Console.WriteLine(((Vadybininkas)d).AtliktiProjektai.Count);
            else
                Console.WriteLine(((SandelioDarbuotojas)d).IsdirbtosValandos);

            Console.WriteLine(d);

        }


    }
}