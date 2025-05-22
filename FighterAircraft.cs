using System;
namespace ConsoleApp1
{
    internal class FighterAircraft : Attacker
    {
        private int FullAmount;
        private int CorntFullAmount;
        private Uman Pilot;
        public FighterAircraft(string name, int amountOfAttecors, List<string> typeOfTarrget,int fullAmount,int corntFullAmount,Uman pilot):base( name,  amountOfAttecors, typeOfTarrget)
        {
            FullAmount = fullAmount;
            CorntFullAmount = corntFullAmount;
            pilot = Pilot;
        }

        

    }
}
