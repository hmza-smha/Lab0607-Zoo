using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    internal class Falcon : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Falcon is Flying...");
        }

        public override void Eat()
        {
            Console.WriteLine("Falcon Eating...");
        }

        public override void Sleep()
        {
            Console.WriteLine("Falcon Sleeping...");
        }

        public override void Sound()
        {
            Console.WriteLine("Falcon Sound...");
        }
    }
}
