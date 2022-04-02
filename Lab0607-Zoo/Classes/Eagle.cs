using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    public class Eagle : Bird
    {
        public override string Fly()
        {
            return "Eagle is Flying...";
        }

        public override void Eat()
        {
            Console.WriteLine("Eagle Eating...");
        }

        public override void Sleep()
        {
            Console.WriteLine("Eagle Sleeping...");
        }

        public override void Sound()
        {
            Console.WriteLine("Eagle Sound...");
        }
    }
}
