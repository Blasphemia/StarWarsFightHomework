using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp1
{
    public class Fighter
    {
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Power { get; set; }
        public string Name { get; set; }






        //public string GetJediWarriorsName()
        //{

        //    List<string> Names = new List<string>();

        //    string path = @"C:/Users/web/source/repos/ConsoleApp1/Jedi.txt";

        //    try
        //    {
        //        using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
        //        {
        //            string line;
        //            while ((line = sr.ReadLine()) != null)
        //            {

        //                Names.Add(line);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //    Random randoM = new Random();
        //    int numOfName = randoM.Next(1, Names.Count + 1);
        //    Fighter warriorsName = new Fighter() { Name = Names[numOfName] };

        //    return warriorsName.Name;
        //}


        //public void GetSithWarriorsName()
        //{

        //    List<string> sithNames = new List<string>();

        //    string path = @"C:/Users/web/source/repos/ConsoleApp1/Sith.txt";

        //    try
        //    {
        //        using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
        //        {
        //            string line;
        //            while ((line = sr.ReadLine()) != null)
        //            {

        //                sithNames.Add(line);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //    //Random randoM = new Random();
        //    //int numOfName = randoM.Next(1, Names.Count + 1);
        //    //Fighter warriorsName = new Fighter() { Name = Names[numOfName] };

        //    //return warriorsName.Name;
        //}



        public int GetWarriorsHP()
        {
            Random rnd = new Random();
            int hp = 50 + rnd.Next(1, 31);
            return hp;
        }

        public int GetWarriorsAttack()
        {
            Random rnd = new Random();
            int attack = 6 + rnd.Next(1, 7);
            return attack;
        }

        public int GetWarriorsPower()
        {
            Random rnd = new Random();
            int power = 1 + rnd.Next(1, 5);
            return power;
        }

        public void GetFighter()
        {
            Fighter fighter = new Fighter() { Attack = GetWarriorsAttack(), Power = GetWarriorsPower(),
                HP=GetWarriorsHP() };
            
           
            
        }

    }
}
