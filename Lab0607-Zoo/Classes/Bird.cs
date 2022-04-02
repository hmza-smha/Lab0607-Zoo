using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    public abstract class Bird : Animal
    {
        private int beakLength;

        public string FeatherColor { get; set; }

        public int BeakLength
        {
            get
            {
                return beakLength;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Beak Length can not be less than 0");
                }
                else
                {
                    beakLength = value;
                }
            }
        }
        
        public virtual string Fly()
        {
            return "Bird is Flying...";
        }

    }
}
