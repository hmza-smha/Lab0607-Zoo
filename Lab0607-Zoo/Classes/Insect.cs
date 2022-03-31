using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    public abstract class Insect : Animal
    {
        private int size;

        public int Size {
            get
            {
                return size;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Size Can not be < 0");
                }
                else
                {
                    size = value;
                }
            }
        }
    }
}
