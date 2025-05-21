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

    public Terrorist(int rank ,List<string> weapons , string status , string name , int age):base(name,age)
        {
            Rank = rank;
            Weapon = weapons;
            Status = status;
        }

    public void getRank()
        {
            Console.WriteLine($"the rank of {base.getName()} is: {Rank}");
        }


    public void getWeapons()
    {
        Console.WriteLine($"the weapons of {base.getName()} is: {Weapon}");
    }

    public void getStatus()
    {
        Console.WriteLine($"the status of {base.getName()} is: {Status}");
    }

    }
}
