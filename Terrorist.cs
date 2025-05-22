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
        private int Rank;
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

<<<<<<< HEAD
    public int GetRank()
        {
            return Rank;
=======
    public string GetRank()
        {
            return $"the rank of {base.GetName()} is: {Rank}";
>>>>>>> e6ce043a861c3fb0c67ce2ad14d97c8b2bac760e
        }

    public List<string> GetWeapon()
    {
        return Weapon;
    }

    public string GetStatus()
    {
<<<<<<< HEAD
        return$"the status of {base.GetName()} is: {Status}";
=======
        return $"the status of {base.GetName()} is: {Status}";
>>>>>>> e6ce043a861c3fb0c67ce2ad14d97c8b2bac760e
    }
    public string GetLocation()
    {
       return LestLocation;
    }

    }
}
