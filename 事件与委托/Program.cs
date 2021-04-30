using System;

namespace 事件与委托
{
    class Program
    {
        static void Main(string[] args)
        {
            MyEvent my = new MyEvent();
            //实例化事件，将委托与方法绑定后指向事件
            my.BuyEvent += new MyEvent.BuyDelegate(my.BuyBanana);
            //触发事件
            my.BuyTrigger();

            Action action = my.BuyBanana;

            action();   
                
                }
    }

    class MyEvent
    {
        //定义委托
        public delegate void BuyDelegate();
        //定义事件
        public event BuyDelegate BuyEvent;
        //定义委托中使用的方法
        public void BuyBanana()
        {
            Console.WriteLine("banana");
        }
        public void BuyApple()
        {
            Console.WriteLine("apple");
        }
        public void BuyOrange()
        {
            Console.WriteLine("orange");
        }
        //定义事件触发器
        public void BuyTrigger()
        {
            BuyEvent();
        }
    }
}
