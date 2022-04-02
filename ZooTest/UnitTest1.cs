using System;
using Xunit;
using Lab0607_Zoo;

namespace ZooTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Bird_Type()
        {
            Bird falcon = new Falcon();
            Assert.Equal("Falcon is Flying...", falcon.Fly());

        }

        [Fact]
        public void Test_Reptile_Type()
        {
            Reptile snake = new Snake();
            Assert.Equal("Snake is Crawling...", snake.Crawling());

        }

        [Fact]
        public void Test_Predator_Type()
        {
            Crocodile crocodile = new Crocodile();

            crocodile.Claws = "Claws";

            Assert.Equal("Claws", crocodile.Claws);

        }
    }
}
