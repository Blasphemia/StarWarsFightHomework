using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp1
{
    public class Fight
    {
        public void AddSquard()
        {

            Squad squadName = new Squad();
            squadName.Name = Academy.CorusantJediAcademy.ToString();
            Console.WriteLine($"Academy Name: {squadName.Name}");
            Fighter sith = new Fighter();
            
           

            Fighter jedi = new Fighter();
            jedi.GetJediWarior();


            //Squad squadOne = new Squad();
            //squadOne.Name = "KorribanSithAcademy";

        }


    }
}
