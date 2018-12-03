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






        public void GetJediWarior()
        {
            Random rnd = new Random();
            int dopHealth = 50 + rnd.Next(1, 31);
            Console.WriteLine(dopHealth);
            Random rand = new Random();
            int dopAttack = 6 + rnd.Next(1, 7);
            Console.WriteLine(dopAttack);
            Random random = new Random();
            int dopPower = 1 + rnd.Next(1, 5);
            Console.WriteLine(dopPower);


            List<string> Names = new List<string>();

            string path = @"C:/Users/web/source/repos/ConsoleApp1/Jedi.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        Names.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Random randoM = new Random();
            int numOfName = randoM.Next(1, Names.Count + 1);
            Fighter warior = new Fighter() { HP = dopHealth, Attack = dopAttack, Power = dopPower, Name = Names[numOfName] };

            Console.WriteLine($"{warior.Attack} {warior.HP} {warior.Name} {warior.Power}");
        }

        public void GetSithWarior()
        {
            Random rnd = new Random();
            int dopHealth = 50 + rnd.Next(1, 31);
            Console.WriteLine(dopHealth);
            Random rand = new Random();
            int dopAttack = 6 + rnd.Next(1, 7);
            Console.WriteLine(dopAttack);
            Random random = new Random();
            int dopPower = 1 + rnd.Next(1, 5);
            Console.WriteLine(dopPower);


            List<string> Names = new List<string>();

            string path = @"C:/Users/web/source/repos/ConsoleApp1/Sith.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        Names.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Random randoM = new Random();
            int numOfName = randoM.Next(1, Names.Count + 1);
            Fighter warior = new Fighter() { HP = dopHealth, Attack = dopAttack, Power = dopPower, Name = Names[numOfName] };

            Console.WriteLine($"{warior.Attack} {warior.HP} {warior.Name} {warior.Power}");
        }




    }
}
