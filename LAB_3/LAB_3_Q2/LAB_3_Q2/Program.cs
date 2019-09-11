using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_q2
{
    class Bird
    {
        public string Name;
        public double Maxheight;
        public double AtHeight;

        public Bird()  //Default Constructor 
        {
            this.Name = "Mountain Eagle";
            this.Maxheight = 500;
        }

        public Bird(string birdname, double max_ht) //Overloaded Constructor 
        {
            this.Name = birdname;
            this.Maxheight = max_ht;
        }


        public void fly()
        {
            Console.WriteLine($"{ this.Name} is flying at altitude { this.Maxheight}");
        }

        public void fly(double AtHeight)
        {
            this.AtHeight = AtHeight;
            if (this.AtHeight <= this.Maxheight)
            {
                Console.WriteLine($"{this.Name} is flying at {this.AtHeight}");
            }
                
            else
            {
                Console.WriteLine($"{this.Name} cannot fly at {this.AtHeight}");
            }                
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bird b = new Bird("Eagle", 200);
            b.fly();
            b.fly(300);
        }
    }
}
