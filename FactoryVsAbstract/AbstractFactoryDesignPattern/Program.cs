namespace AbstractFactoryDesignPattern
{
    public interface ICar
    {
        void Manufacture();
    }

    public interface IBike
    {
        void Manufacture();
    }

    public class TataCar : ICar
    {
        public void Manufacture()
        {
            Console.WriteLine("Tata car manufacture");
        }
    }

    public class TataBike : IBike
    {
        public void Manufacture()
        {
            Console.WriteLine("Tata bike manufacture");
        }
    }

    public class TeslaCar : ICar
    {
        public void Manufacture()
        {
            Console.WriteLine("Tesla car manufacture");
        }
    }

    public class TeslaBike : IBike
    {
        public void Manufacture()
        {
            Console.WriteLine("Tesla bike manufacture");
        }
    }

    //Abstract factory class
    public abstract class VechileCompany
    {
        public abstract ICar GetCar();
        public abstract IBike GetBike();
    }

    public class TeslaCompany : VechileCompany
    {
        public override IBike GetBike()
        {
            return new TeslaBike();
        }

        public override ICar GetCar()
        {
            return new TeslaCar();
        }
    }

    public class TataCompany : VechileCompany
    {
        public override IBike GetBike()
        {
            return new TataBike();
        }

        public override ICar GetCar()
        {
            return new TataCar();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            VechileCompany tata = new TataCompany();
            VechileCompany tesla = new TeslaCompany();
            tata.GetBike().Manufacture();
            tesla.GetBike().Manufacture();
            tata.GetCar().Manufacture();
            tesla.GetCar().Manufacture();
        }
    }
}