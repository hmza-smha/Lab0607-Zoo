using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    internal class Crocodile : Reptile
    {
        public override void Crawling()
        {
            Console.WriteLine("Crocodile is Crawling...");
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
