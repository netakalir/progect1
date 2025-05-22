using System;

namespace ConsoleApp1
{
    internal class Attacker
    {
        private string Name;
        private int AmountOfAttecors;
        private List<string> TypeOfTarrget;
        private int CountAmountOfAttecors;


        public Attacker(string name,int amountOfAttecors,List<string>typeOfTarrget)
        {
            Name = name;
            AmountOfAttecors = amountOfAttecors;
            TypeOfTarrget = typeOfTarrget;
            CountAmountOfAttecors = AmountOfAttecors;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetAmountOfAttecors()
        {
            return AmountOfAttecors;
        }
        public List<string> GetTypeOfTarrget()
        {
            return TypeOfTarrget;
        }

        public void CangeAmountOFAttecker(int inattack)
        {
            if (inattack < CountAmountOfAttecors)
            {
                Console.WriteLine("not enough to attack");
            }
            else
            {
                int CountAmountOfAttecors = - inattack;
            }
        }







    }
}
