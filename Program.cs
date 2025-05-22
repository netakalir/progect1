using System;
using System.Runtime.InteropServices.Marshalling;
using ConsoleApp1;


namespace Idf
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> s1 = new List<string> { "EFB", "ervbt", "Erg" };
            Attacker a1 = new Attacker("RGV", 43, s1);
            Uman u1 = new Uman("br", 45);
            FighterAircraft f16 = new FighterAircraft("RGV", 43, s1, 34, 325, u1);
            Console.WriteLine(f16.GetName());
        }

        
    }
}