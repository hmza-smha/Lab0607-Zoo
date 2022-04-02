using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    public class Crocodile : Reptile, IPredator
    {
        public string Claws { get; set; }
        public string Teeth { get; set; }

        public override string Crawling()
        {
            return "Crocodile is Crawling...";
        }
        public override void Eat()
        {
            Console.WriteLine("Crocodile is Eating...");
        }

        public override void Sleep()
        {
            Console.WriteLine("Crocodile is Sleeping...");
        }

        public override void Sound()
        {
            Console.WriteLine("Crocodile Sound...");
        }
    }
}
