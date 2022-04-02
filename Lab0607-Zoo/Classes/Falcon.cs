using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    public class Falcon : Bird
    {
        public override string Fly()
        {
            return "Falcon is Flying...";
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
