using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWIndowSizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.WindowWidth);
            Console.WriteLine(Console.WindowHeight);
           
            var rnd = new Random();
            var list = new List<Int32>();
            list.Add(rnd.Next(3));
            list.Add(rnd.Next(3));
            list.Add(rnd.Next(3));
            list.Add(rnd.Next(3));
            list.Add(rnd.Next(3));
            list.Add(rnd.Next(3));
            list.Add(rnd.Next(3));
            list.RemoveAt(3);
            
            Console.ReadKey();
        }
    }
}
