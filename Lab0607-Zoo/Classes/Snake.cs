using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    public class Snake : Reptile
    {
        public override string Crawling()
        {
            return "Snake is Crawling...";
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
