using System;

namespace Lab0607_Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird falcon = new Falcon();
            falcon.Sound();
            falcon.Fly();

            Mammal elephant = new Elephant();
            elephant.Walk();

            Reptile snake = new Snake();
            snake.SkinColor = "grey";
            Console.WriteLine("Snake Color: " + snake.SkinColor);
            snake.Crawling();

        }
    }
}
