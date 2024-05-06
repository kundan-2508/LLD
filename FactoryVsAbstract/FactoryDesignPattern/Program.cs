//namespace FactoryDesignPattern
//{
//    public interface Icar
//    {
//        void start();
//    }
//    public class SixSeaterCar : Icar
//    {
//        public void start()
//        {
//            Console.WriteLine("Six Seater car sstarted");
//        }
//    }
//    public class FourSeaterCar : Icar
//    {
//        public void start()
//        {
//            Console.WriteLine("Four Seater car sstarted");
//        }
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Icar SixSeater = new SixSeaterCar();
//            Icar FourSeater = new FourSeaterCar();
//            SixSeater.start();
//            FourSeater.start();
//        }
//    }
//}

//above code is not good, we can implement the same thing using factory design pattern

namespace FactoryDesignPattern
{
    public interface ICar
    {
        void Start();
    }

    public class SixSeater : ICar
    {
        public void Start()
        {
            Console.WriteLine("Six Seater car started");
        }
    }

    public class FourSeater : ICar
    {
        public void Start()
        {
            Console.WriteLine("Four Seater car started");
        }
    }

    public class CarFactory
    {
        public ICar getCar(string type)
        {
            switch (type)
            {
                case "four":
                    return new FourSeater();
                case "six":
                    return new SixSeater();
            }
            return null;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new CarFactory();
            ICar fourSeater = carFactory.getCar("four");
            ICar sixSeater = carFactory.getCar("six");
            sixSeater.Start();
            fourSeater.Start();
        }
    }
}
