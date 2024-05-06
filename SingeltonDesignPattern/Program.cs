//what is singelton design pattern

//Singelton design pattern restricts the instantiation of a class to one single object
//Throughout the lifetime of the application, the instance will remain same
//class should be sealed and its constructor should be private
//instance should be requested instaed of created


//why we need singelton pattern



namespace SingeltonDesignPattern{    public sealed class Singelton
    {
        private static object obj;
        private static Singelton instance;
        private Singelton()
        {
            //Private constructor
        }
        public static Singelton GetInstance()
        {
            lock (obj)
            {
                if(obj == null)
                {
                    instance = new Singelton();
                }
                return instance;
            }
        }
        //public class OtherClass : Singelton
        //{
        //    // here we can inherit if we don't put sealed keyword
        //    // this is the reason we put sealed keyword
        //}

    }    //public class OtherClass : Singelton
    //{
    //    // we cannot inherit due to sealed class
    //    //event if we remove the sealed keyword, this will not work due to private constructor
    //    //try removing seled keyword
    //}    public class Program    {        static void Main(string[] args)        {            Singelton s1 = Singelton.GetInstance();            Singelton s2 = Singelton.GetInstance();
            //both s1 and s2 instance would be same
            //Singelton.OtherClass o = new Singelton.OtherClass(); // this is working if we don't put sealed, hence we must put sealed keyword        }    }}