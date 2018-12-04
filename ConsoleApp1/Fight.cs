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
        public void AddFraction()
        {


            Fraction firstFraction = new Fraction();
            firstFraction.Name = Academy.KorribanSithAcademy.ToString();
            firstFraction.Squads = new List<Squad>();
            Console.WriteLine(firstFraction.Name);
            Squad sithSquad = new Squad() { Name = Academy.FirstSithSquad.ToString(), Fighters = new List<Fighter>() };
            Console.WriteLine(sithSquad.Name);
            Fighter w = new Fighter();
            
            List<string> sithNames = new List<string>();

            string path = @"C:/Users/web/source/repos/StarWarsFightHomework/Sith.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        sithNames.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            for (int i = 0; i < 10; i++)
            { Random rnd = new Random();
                int index = rnd.Next(0, sithNames.Count);
                string name = sithNames[index];
                Fighter sithwarrior = new Fighter()
                {
                    Attack = w.GetWarriorsAttack(),
                    HP = w.GetWarriorsHP(),
                    Power = w.GetWarriorsPower(),
                    Name = name
                };
                Console.WriteLine($"Sith warrior named {sithwarrior.Name} with {sithwarrior.HP} health points, " +
                    $"{sithwarrior.Power} power points and with {sithwarrior.Attack} attack power.");
                index = 0;
            }




            Console.WriteLine(firstFraction.Name);
            Squad sithSquadTwo = new Squad() { Name = Academy.SecondSithSquad.ToString(), Fighters = new List<Fighter>() };
            Console.WriteLine(sithSquadTwo.Name);
            Fighter war = new Fighter();
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, sithNames.Count);
                string name = sithNames[index];
                Fighter sithwarrior = new Fighter()
                {
                    Attack = w.GetWarriorsAttack(),
                    HP = w.GetWarriorsHP(),
                    Power = w.GetWarriorsPower(),
                    Name = name
                };
                Console.WriteLine($"Sith warrior named {sithwarrior.Name} with {sithwarrior.HP} health points, " +
                    $"{sithwarrior.Power} power points and with {sithwarrior.Attack} attack power.");
                index = 0;
            }



            Console.WriteLine("\n");

            Fraction secondFraction = new Fraction();
            secondFraction.Name = Academy.CorusantJediAcademy.ToString();
            secondFraction.Squads = new List<Squad>();
            Console.WriteLine(secondFraction.Name);
            Squad jediSquad = new Squad() { Name = Academy.FirstJediSquad.ToString(), Fighters = new List<Fighter>() };
            Console.WriteLine(jediSquad.Name);
            Fighter f = new Fighter();

            List<string> jediNames = new List<string>();

            string newpath = @"C:/Users/web/source/repos/StarWarsFightHomework/Jedi.txt";

            try
            {
                using (StreamReader sr = new StreamReader(newpath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        jediNames.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, jediNames.Count);
                string name = jediNames[index];
                Fighter jediwarrior = new Fighter()
                {
                    Attack = f.GetWarriorsAttack(),
                    HP = f.GetWarriorsHP(),
                    Power = f.GetWarriorsPower(),
                    Name = name
                };
                Console.WriteLine($"Jedi warrior named {jediwarrior.Name} with {jediwarrior.HP} health points, " +
                    $"{jediwarrior.Power} power points and with {jediwarrior.Attack} attack power.");
                index = 0;
            }




            Console.WriteLine(secondFraction.Name);
            Squad jediSquadTwo = new Squad() { Name = Academy.SecondJediSquad.ToString(), Fighters = new List<Fighter>() };
            Console.WriteLine(jediSquadTwo.Name);
            Fighter warr = new Fighter();
           

            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, jediNames.Count);
                string name = jediNames[index];
                Fighter jediwarrior = new Fighter()
                {
                    Attack = f.GetWarriorsAttack(),
                    HP = f.GetWarriorsHP(),
                    Power = f.GetWarriorsPower(),
                    Name = name
                };
                Console.WriteLine($"Jedi warrior named {jediwarrior.Name} with {jediwarrior.HP} health points, " +
                    $"{jediwarrior.Power} power points and with {jediwarrior.Attack} attack power.");
                index = 0;
            }








        }
        

    }
    
}
