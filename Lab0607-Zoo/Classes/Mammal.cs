using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    public abstract class Mammal : Animal
    {
        public string HairColor { get; set; }

        public virtual void Walk()
        {
            Console.WriteLine("Mammal is Walking...");
        }
    }
}
