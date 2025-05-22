using System;
using ConsoleApp1;


namespace Idf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("gbfh");
            //Uman u1 = new Uman("dfgf", 5);
            //Terrorist t1 = new Terrorist(5, ["dfs", "df"], "live","han yons", "dfs", 20);
            //Console.WriteLine(t1.GetRank());
            //IdfOrganization i1 = new IdfOrganization(1948, "aiil zamir", ["Air force", "Artillery", "Drones"]);
            //i1.GetComendurName();
            //foreach (string ability in i1.GetAttackCapabilities())
            //{
            //    Console.WriteLine($"{ability}");
            //}
            //foreach (string weapon in t1.GetWeapon())
            //{
            //    Console.WriteLine($"{weapon}");
            //}
            List<string> a1 = new List<string> { "Svfs", "swgver", "wdgs" };
            Attacker aq1 = new Attacker("dwq", 44, a1);
            Console.WriteLine(aq1.GetName());
            Console.WriteLine(aq1.GetTypeOfTarrget());
            Console.WriteLine(aq1.GetAmountOfAttecors());



        }
    }
}