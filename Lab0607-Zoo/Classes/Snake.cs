using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    internal class Snake : Reptile
    {
        public override void Crawling()
        {
            Console.WriteLine("Snake is Crawling...");
        }
        public override void Eat()
        {
            Console.WriteLine("Snake is Eating...");
        }

        public override void Sleep()
        {
            Console.WriteLine("Snake is Sleeping...");
        }

        public override void Sound()
        {
            Console.WriteLine("Snake Sound...");
        }
    }
}
