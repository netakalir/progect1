using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Idf;


namespace ConsoleApp1
{
    public class Hamas
    {
        
            private int DateOfEstablishment;
            private string CurrentComendur;
            private List<Terrorist> ListOfTerrorist;


            public Hamas(int dateOfEstablishment, string currentComendur, List<Terrorist> listOfTerrorist)
            {
                DateOfEstablishment = dateOfEstablishment;
                CurrentComendur = currentComendur;
                ListOfTerrorist = listOfTerrorist;
            }
        


        public List<Terrorist> GetTeroristList()
        {
            return ListOfTerrorist;
        }



    }
}
