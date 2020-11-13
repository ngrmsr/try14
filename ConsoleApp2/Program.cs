using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Pride();
            SpringOffer springOffer = new SpringOffer(car);
        }
    }
    public interface ICar
    {
         string Factory { get;}
         string Model { get;}
         int Price { get;}
    }
    class Pride : ICar
    {
        public string Factory { get => "sipa";}
        public string Model { get => "110"; }
        public int Price { get => 150000000;}
    }
    public abstract class CarDecorator : ICar
    {
        private readonly ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public string Factory => car.Factory;

        public string Model => car.Model;

        public int Price => car.Price;
    }
    public class SpringOffer : CarDecorator
    {
        public SpringOffer(ICar car):base(car)
        {

        }
        int offer = 20;
        public double Price
        {
            get
            {
                var realPrice = base.Price;
                return Math.Round((Price * (100 - offer) / 100),2);
            }
        }
    }
}
