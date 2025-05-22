using System;
using ConsoleApp1;


namespace Idf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gbfh");
            Uman u1 = new Uman("dfgf", 5);
            Terrorist t1 = new Terrorist(5, ["dfs", "df"], "live","han yons", "dfs", 20);
            Console.WriteLine(t1.Rank);
            IdfOrganization i1 = new IdfOrganization(1948, "aiil zamir", ["Air force", "Artillery", "Drones"]);
            i1.GetComendurName();
            foreach (string ability in i1.GetAttackCapabilities())
            {
                Console.WriteLine($"{ability}");
            }
            foreach (string weapon in t1.GetWeapon())
            {
                Console.WriteLine($"{weapon}");
            }



        }
    }
}