using System;
using System.Runtime.InteropServices.Marshalling;
using ConsoleApp1;


namespace Idf
{
    class Program
    {
        static void Main(string[] args)
        {

<<<<<<< HEAD
=======
            List<string> s1 = new List<string> { "EFB", "ervbt", "Erg" };
            Attacker a1 = new Attacker("RGV", 43, s1);
            Uman u1 = new Uman("br", 45);
            FighterAircraft f16 = new FighterAircraft("RGV", 43, s1, 34, 325, u1);
            Console.WriteLine(f16.GetName());


>>>>>>> new
            Terrorist t1 = new Terrorist(1, ["M16"], "live", "han yons", "mhmod", 50);
            Terrorist t2 = new Terrorist(2, ["gun", "knife"], "ded", "gaza", "sinour", 30);
            Terrorist t3 = new Terrorist(1, ["AK47", "knife"], "live", "raphih", "df", 60);
            Terrorist t4 = new Terrorist(4, ["knife"], "ded", "han yons", "yosof", 40);
            Terrorist t5 = new Terrorist(5, ["gun"], "live", "gbalia", "mhmod", 25);
            List<Terrorist> Terroristim = new List<Terrorist> { t1, t2, t3, t4, t5 };
<<<<<<< HEAD
            Hamas H1 = new Hamas(1988, "sinoer", Terroristim);
            AMN amn = new AMN(H1.GetTeroristList());
            Console.WriteLine(amn.RiskCalculation().GetStatus());
=======
            //Hamas mjmm = new Hamas(1988, "sinoer", Terroristim);
            //AMN amn = new AMN(mjmm.GetTeroristList());
            //Console.WriteLine( amn.RiskCalculation().GetStatus());

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
            List<string> jbb = new List<string> { "Svfs", "swgver", "wdgs" };
            Attacker aq1 = new Attacker("dwq", 44, jbb);
            Console.WriteLine(aq1.GetName());
            Console.WriteLine(aq1.GetTypeOfTarrget());
            Console.WriteLine(aq1.GetAmountOfAttecors());
>>>>>>> new


           

<<<<<<< HEAD
=======



>>>>>>> new
        }
    }
}
