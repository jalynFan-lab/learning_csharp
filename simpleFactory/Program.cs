using System;

namespace simpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用多态中的抽象类实现简单工厂模式
            Console.WriteLine("请输入需要的电脑品牌");
            string brand = Console.ReadLine();
            NoteBook nb = getNoteBook(brand);
            nb.Say();
        }


        public static NoteBook getNoteBook(string brand) 
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "dell":
                    nb = new Dell();
                    break;
                case "lenovo":
                    nb = new Lenovo();
                    break;
            }

            return nb;

        }

    }

    public abstract class NoteBook 
    {
        public abstract void Say();
    }

    public class Dell:NoteBook
    {
        public override void Say()
        {
            Console.WriteLine("Dell");
        }
    }

    public class Lenovo : NoteBook
    {
        public override void Say()
        {
            Console.WriteLine("Lenovo");
        }
    }

   
}
