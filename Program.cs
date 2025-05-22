using System;
using System.Runtime.InteropServices.Marshalling;
using ConsoleApp1;


namespace Idf
{
    class Program
    {
        static void Main(string[] args)
        {

           


            Terrorist t1 = new Terrorist(1, ["M16"], "live", "han yons", "mhmod", 50);
            Terrorist t2 = new Terrorist(2, ["gun", "knife"], "ded", "gaza", "sinour", 30);
            Terrorist t3 = new Terrorist(1, ["AK47", "knife"], "live", "raphih", "df", 60);
            Terrorist t4 = new Terrorist(4, ["knife"], "ded", "han yons", "yosof", 40);
            Terrorist t5 = new Terrorist(5, ["gun"], "live", "gbalia", "mhmod", 25);
            List<Terrorist> Terroristim = new List<Terrorist> { t1, t2, t3, t4, t5 };
            List<string> atteacres = new List<string> { "f16", "Dron", "nisels" };
            IdfOrganization IDF = new IdfOrganization(26051948, "eyalzamir", atteacres);
            FighterAircraft f16 = new FighterAircraft("f16", 30000, new List<string> { "buildings" }, 300000, 8, new Uman("gabi", 28));







        }
    }
}
