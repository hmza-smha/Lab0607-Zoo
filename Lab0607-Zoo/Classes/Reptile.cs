using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    public abstract class Reptile : Animal
    {
        private int length;

        public string SkinColor { get; set; }

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Length Can not be < 0");
                }
                else
                {
                    length = value;
                }
            }
        }

        public virtual string Crawling()
        {
            return "Reptile is Crowling...";
        }
    }
}
