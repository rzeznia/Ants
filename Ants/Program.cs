using System;
using System.Collections.Generic;

namespace Ants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(72, 24);
            Console.BufferHeight = 30;
            Console.BufferWidth = 72;
            Random rnd = new Random();
            CreateBattleGround();
            var ants = PrepareAnts(5000);
            foreach (var ant in ants)
                ant.Show(1);
            for (;;)
            {
                for (int i = 0; i < ants.Count; i++)
                {
                    Random rnd1 = new Random();
                    System.Threading.Thread.Sleep(5);
                    ants[i].Move(rnd1, ants);
                    Console.SetCursorPosition(4,22);
                    Console.Write(ants.Count);
                }
                if (ants.Count == 0)
                    break;  
            }
            Console.ReadKey();  
        }
        static void CreateBattleGround()
        {
            int x = 71; int y = 21; int i = 0; int j = 0;
            System.Console.Clear();
            for (j = 0; j <= y; j++)
            {
                for (i = 0; i <= x; i++)
                {
                    if (j == 0)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write('#');
                    }
                    if (j == y)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write('#');
                    }
                    if(j != 0 && j != y)
                    {
                        if (i == 0)
                        {
                            Console.SetCursorPosition(0, j);
                            Console.Write('#');
                        }
                        if (i != x) continue;
                        Console.SetCursorPosition(i, j);
                        Console.Write('#');
                    }
                }  
            }
        }
        public static List<Ant> PrepareAnts(int population)
        {
           
            var ants = new List<Ant>();
            Random rnd = new Random();
            for (;;)
            {
                int x = rnd.Next(1, 70);
                int y = rnd.Next(1, 20);
                foreach (var ant in ants)
                {
                    if (ant.X == x && ant.Y == y)
                    {
                        break;
                    }
                } 
                ants.Add(new Ant(x,y));
                if (ants.Count == population)
                    break;
            } 
            return ants;
        }
    }
}
