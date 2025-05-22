using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Idf;

namespace ConsoleApp1
{
    public class Terrorist : Uman
    {
        public int Rank;
        private List<string> Weapon;
        private string Status;
        private string LestLocation;
        
        public Terrorist(int rank ,List<string> weapons , string status , string location, string name , int age):base(name,age)
        {
            Rank = rank;
            Weapon = weapons;
            Status = status;
            LestLocation = location;

        }

    public void GetRank()
        {
            Console.WriteLine($"the rank of {base.GetName()} is: {Rank}");
        }


    public List<string> GetWeapon()
    {
        return Weapon;
    }

    public void GetStatus()
    {
        Console.WriteLine($"the status of {base.GetName()} is: {Status}");
    }
    public string GetLocation()
    {
       return LestLocation;
    }

    }
}
