using System;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            IAPP aPP = new Note();
            string str = aPP.Eat();
            Console.WriteLine(str);        }
    }

    public interface IAPP
    {
        public string Eat() 
        {
            return "eat";
        }
    }


    public class Note : IAPP
    {
        public string Eat()
        {
            return "ate";
        }
    }
}
