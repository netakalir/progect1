using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Idf;

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

        public string GetComendurName()
        {
            return $"Comendur name is {CurrentComendur}";
        }
        public List<string> GetAttackCapabilities()
        {
            return AttackCapabilities;
        }
    }
}
