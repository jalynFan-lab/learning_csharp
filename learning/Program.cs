using System;
using System.Collections;

namespace 復習
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 里氏转换:父类是子类对象的一个实例，则可以强转为子类对象
            /*Person p = new Student();
            Student stu = p as Student;
            if (p is Student) 
            {
                stu.StudentSayhi();
            }
            else 
            {
                Console.WriteLine("convert is failed");
            }*/
            #endregion
            #region hashtable

            Hashtable ht = new Hashtable();
            ht.Add(1, "计算机基础");
            ht.Add(2, "C#高级编程");
            ht.Add(3, "数据库应用");

            foreach (var h in ht.Keys) 
            {
                Console.WriteLine(ht[h]);
            }
            #endregion
        }
    }


    class Person 
    {
        public void personSayHi() 
        
        {
            Console.WriteLine("person is saying hello");
        }
    }

    class Student:Person
    {
        public void StudentSayhi() 
        {
            Console.WriteLine("stu is saying hello");
        
        }


    }
}
