using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    internal class Elephant : Mammal
    {
        private int elephantTrunkLength;

        public int ElephantTrunkLength
        {
            get
            {
                return elephantTrunkLength;
            }
            set
            {
                if(elephantTrunkLength < 0)
                {
                    if(elephantTrunkLength < 0)
                    {
                        Console.WriteLine("Elephant Trunk can not be < 0");
                    }
                    else
                    {
                        elephantTrunkLength = value;
                    }
                }
            }
        }

        public override void Eat()
        {
            Console.WriteLine("Elephant is Eating...");
        }

        public override void Sleep()
        {
            Console.WriteLine("Elephant is Sleeping...");
        }

        public override void Sound()
        {
            Console.WriteLine("Elephant Sound...");
        }

        public override void Walk()
        {
            Console.WriteLine("Elephant is Walking");
        }
    }
}
