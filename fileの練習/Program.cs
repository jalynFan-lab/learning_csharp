using System;
using System.IO;
using System.Text;

namespace fileの練習
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Create("C://Users//kyo.han//Desktop//file.txt");
            //Console.WriteLine("File is created");
            #region  ReadAllBytes多用于读取自媒体文件
            /*
                        byte[] bytes = File.ReadAllBytes("C://Users//kyo.han//Desktop//file.txt");

                        string s = Encoding.Default.GetString(bytes);

                        Console.WriteLine(s);


                        string str = "nihao";
                        byte[]  fileByte = Encoding.Default.GetBytes(str);
                        File.WriteAllBytes("C://Users//kyo.han//Desktop//file.txt", fileByte);*/ //最后覆盖上源文件，不是添加
            #endregion

            #region ReadAllLines,ReadAllText 多用来读文本文件,返回数组可以对每行数据进行操作
            /*string[] strLines = File.ReadAllLines("C://Users//kyo.han//Desktop//file.txt",Encoding.Default);
            foreach (string item in strLines)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**********************************");
            string texts = File.ReadAllText("C://Users//kyo.han//Desktop//file.txt", Encoding.Default);
            Console.WriteLine(texts);*/

            #endregion

            #region AppendAllLines AppendAllText 不覆盖
            File.AppendAllLines("C://Users//kyo.han//Desktop//file.txt",new string[] { "abc","123"} );
            File.AppendAllText("C://Users//kyo.han//Desktop//file.txt", "abc");
            #endregion
        }
    }
}
