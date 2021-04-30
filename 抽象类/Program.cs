using System;

namespace 抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            //父类有方法的实现，需要被实例化需要使用虚方法
            //父类没有方法的实现，不许哟啊被实例化用抽象类

            //求矩形的面积和周长以及圆形的面积和周长

            Shape shape = new Circle(2);
            double area =  shape.getArea();
            double per = shape.getPerimiter();
            Console.WriteLine("area:{0},perimiter:{1}",area,per);
        }

    }

    public abstract class Shape 
    {

        public abstract double getArea();

        public abstract double getPerimiter();

    
    }


    public class Circle : Shape
    {
        public double R { get; set; }

        public Circle(double r)
        {
            this.R = r;
        }
        public override double getArea()
        {
            return this.R * this.R * Math.PI;
        }

        public override double getPerimiter()
        {
            return this.R * Math.PI * 2;
        }
    }


    public class Square : Shape
    {
        public double Longth
        {
            get;set;
        }

        public double Width
        {
            get; set;
        }

        public Square(double longth, double width)
        {
            this.Longth = longth;
            this.Width = width;
        }


        public override double getArea()
        {
            return this.Longth * this.Width;
        }

        public override double getPerimiter()
        {
            return (this.Width + this.Longth) * 2;
        }
    }
}
