using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Idf;

namespace ConsoleApp1
{
    public class Uman
    {
        private string Name;
        private int Age;


        public Uman(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string getName()
            {
                return Name;
            }

        public int getAge()
        {
            return Age;
        }
    }
}
