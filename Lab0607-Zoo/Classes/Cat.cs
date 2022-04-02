using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    public class Cat : Mammal, IPredator
    {
        public string Type { get; set; }
        public string Claws { get; set; }
        public string Teeth { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Cat is Eating...");
        }

        public override void Sleep()
        {
            Console.WriteLine("Cat is Sleeping...");
        }

        public override void Sound()
        {
            Console.WriteLine("Cat Sound...");
        }

        public override void Walk()
        {
            Console.WriteLine("Cat is Walking...");
        }
    }
}
