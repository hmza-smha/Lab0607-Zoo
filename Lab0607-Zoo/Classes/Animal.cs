using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0607_Zoo
{
    public abstract class Animal : IAnimal
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

        public void Alive()
        {
            Console.WriteLine("The Animal is Alive");
        }

        public void Body()
        {
            Console.WriteLine("The Animal has a body");
        }

        public abstract void Eat();

        public void Eyes()
        {
            Console.WriteLine("The Animal has Eyes");
        }

        public void Hands()
        {

            Console.WriteLine("The Animal has Hands");
        }

        public void Head()
        {

            Console.WriteLine("The Animal has Head");
        }

        public abstract void Sleep();
        public abstract void Sound();
    }
}
