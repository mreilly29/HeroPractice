using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroPractice
{
    class Hero
    {
        //FIELDS
        private string name;
        private int strength = 100;
        private bool cape;
        private int flyingSpeed = 50;

        //PROPERTIES
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Strength
        {
            get { return this.strength; }
            set { this.strength = value; }
        }

        public bool Cape
        {
            get { return this.cape; }
            set { this.cape = value; }
        }

        public int FlyingSpeed
        {
            get { return this.flyingSpeed; }
            set { this.flyingSpeed = value; }
        }

        //CONSTRUCTORS
        public Hero()
        {

        }

        public Hero(string person)
        {
            this.Name = person;
        }

        public Hero(string person, bool capes )
        {
            this.Name = person;
            this.Cape = capes;
        }

        //METHODS       
        public void HasCape(bool hasCape, string person)
        {
            if(hasCape == true)
            {
                FlyingSpeed -= 10;
                Console.WriteLine("{0}! You fool! Capes can kill you. Flying speed minus 10.", Name);
            }
            else if(person.ToLower() == "pete")
            {
                Console.WriteLine("Hey Super " + Name + "! You're awesome. Strength restored to 100.");
                Strength = 100;
            }
            else
            {
                Console.WriteLine("No cape? Smart choice! Flying speed plus 5.");
                FlyingSpeed += 5;
            }
        }

        public void HealthStatus()
        {
            strength -= 10;
            Console.WriteLine("Stop checking your health. Strength minus 10.");
        }

        public void InDanger()
        {
            Console.WriteLine("Now {0}.. I don't mean to be rude, but have you slacked with your classmates?", Name);
            if (Console.ReadLine().ToLower() == "yes")
            {
                FlyingSpeed += 10;
                Console.WriteLine("You're listening skills are incredible. Please Accept these 10 points for your bike speed!");
            }
            else
            {
                FlyingSpeed -= 20;
                Strength -= 50;
                Console.WriteLine("You know the drill, SLACK YOUR CLASSMATES FIRST.");
                Console.WriteLine("Shame. Flying speed minus 20. Strength minus 50.");
            }

        }
    }
}
