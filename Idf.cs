using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Idf;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class IdfOrganization
    {
        private int DateOfEstablishment;
        private string CurrentComendur;
        private List<string> AttackCapabilities;


        public IdfOrganization(int dateOfEstablishment, string currentComendur, List<string> attackCapabilities)
        {
            DateOfEstablishment = dateOfEstablishment;
            CurrentComendur = currentComendur;
            AttackCapabilities = attackCapabilities;
        }

        public void GetComendurName()
        {
            Console.WriteLine($"Comendur name is {CurrentComendur}");
        }
        public List<string> GetAttackCapabilities()
        {
            return AttackCapabilities;
        }
    }
}
