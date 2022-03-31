using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    public class Dog : Mammal
    {
        public string Type { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Dog is Eating...");
        }

        public override void Sleep()
        {
            Console.WriteLine("Dog is Sleeping...");
        }

        public override void Sound()
        {
            Console.WriteLine("Dog Sound...");
        }

        public override void Walk()
        {
            Console.WriteLine("Dog is Walking...");
        }
    }
}
