using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    internal class Bee : Insect
    {
        public override void Eat()
        {
            Console.WriteLine("Ant is Eating...");
        }

        public override void Sleep()
        {
            Console.WriteLine("Ant is Sleeping...");
        }

        public override void Sound()
        {
            Console.WriteLine("Ant Sound...");
        }
    }
}
