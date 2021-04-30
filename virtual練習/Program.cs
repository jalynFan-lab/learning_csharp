using System;

namespace virtual練習
{
    class Program
    {
        static void Main(string[] args)
        {
            //小孩 老人 年轻人

            Person pr = new Person();

            Chidren chidren = new Chidren();

            Old old = new Old();

            Young young = new Young();

            Person[] pers = { pr,chidren,old,young};

            foreach (var item in pers)
            {
                item.Walk();
            }

        }
    }

    class Person
    {
        public virtual void Walk()
        {
            Console.WriteLine("人間走");
        }
    }

    class Chidren:Person
    {
        public override void Walk() 
        {
            Console.WriteLine("小孩爬着走");
        }
    }

    class Old : Person
    {
        public override void Walk()
        {
            Console.WriteLine("老人拄拐走");
        }
    }

    class Young : Person
    {
        public override void Walk()
        {
            Console.WriteLine("年轻人两腿走");
        }
    }

}
