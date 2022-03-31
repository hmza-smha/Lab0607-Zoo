using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    public abstract class Animal
    {
        private int age;

        private int weigth;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age Can not be < 0");
                }
                else
                {
                    age = value;
                }
            }
        }


        public int Weight
        {
            get
            {
                return weigth;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Weight Can not be < 0");
                }
                else
                {
                    weigth = value;
                }
            }
        }

        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Sound();
    }
}
