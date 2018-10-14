using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero man = new Hero();
            Console.WriteLine("Hey hero! What's your name?");
            man.Name = Console.ReadLine();
            Console.WriteLine("Hi Super {0}. Let's go on an adventure!", man.Name);
            Console.WriteLine("True or False: Do you have a cape?");
            bool input = bool.Parse(Console.ReadLine().ToLower());
            man.HasCape(input,man.Name);
            Console.WriteLine("{0} are you in danger?", man.Name);
            if (Console.ReadLine().ToLower() == "yes")
            {
                man.InDanger();
            }
        


        }
    }
}
