using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Idf;

namespace ConsoleApp1
{
    public class AMN
    {
        private List<Terrorist> terrorists;
        Dictionary<string, int> WeaponsrRating = new Dictionary<string, int>()
        {
            {"knife",1},
            {"gun",2},
            {"M16",3},
            {"AK47",3}
        };

        public AMN(List<Terrorist> existingTerrorists)

        {
            terrorists = existingTerrorists ?? throw new ArgumentNullException(nameof(existingTerrorists));
        }



        public Terrorist RiskCalculation()
        {
            int Max = 0;
            Terrorist DTerorist = new Terrorist(5, ["gun"], "live", "gbalia", "mhmod", 25);
            foreach (Terrorist ter in terrorists)
            {
                int Max1 = 0;
                int rank = ter.GetRank();
                List<string> weapons = ter.GetWeapon();
                foreach (string weapon in weapons)
                {
                    Max1 += WeaponsrRating[weapon];
                }

                Max1 = rank * Max1;

                if (Max1 >= Max)
                {
                    Max = Max1;
                    DTerorist = ter;
                }
            }
            return DTerorist;
        }
    }

}

