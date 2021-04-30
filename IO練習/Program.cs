using System;
using System.IO;
using System.Text;

namespace IO練習
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream 
            //读取
            /*FileStream stream = new FileStream("C://Users//kyo.han//Desktop//file.txt", FileMode.OpenOrCreate,FileAccess.ReadWrite);

            byte[] bytes = new byte[1024 * 1024 *  5];

            int r = stream.Read(bytes,0,bytes.Length);//实际读取到的字节数

            string str = Encoding.Default.GetString(bytes,0,r);//解码字节数组中的值为string

            stream.Close();//关流
            stream.Dispose();//释放流中的资源

            Console.WriteLine(str);*/
            //写入
            /*using (FileStream fileStream = new FileStream("C://Users//kyo.han//Desktop//file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)) 
            {
                string tempStr = @"实际读取到的字节数";
                byte[] buffer = Encoding.UTF8.GetBytes(tempStr);
                fileStream.Write(buffer,0,buffer.Length);
            }*/


            //复制 读取一个文件然后写入到另一个文件中

            /*string from = @"C:\Users\kyo.han\Desktop\from.jpg"; 
            string to = @"C:\Users\kyo.han\Desktop\to.jpg";

            using (FileStream readStream = new FileStream(from,FileMode.Open, FileAccess.Read))
            {
                using (FileStream writeStream = new FileStream(to,FileMode.OpenOrCreate,FileAccess.Write)) 
                
                {
                    byte[] bytes = new byte[1024 * 1024];

                    int result = 0;
                    while ((result  = readStream.Read(bytes, 0, bytes.Length))!= 0)
                    {
                        writeStream.Write(bytes, 0,result);
                    }
                }
                
                
            }*/

            //streamReader streamWriter

          /*  using (StreamReader streamReader = new StreamReader("C://Users//kyo.han//Desktop//from.txt")) 
            {
                while (!streamReader.EndOfStream)
                {
                    Console.WriteLine(streamReader.ReadLine());
                }
                
            }
*/
            using (StreamWriter streamWriter = new StreamWriter("C://Users//kyo.han//Desktop//to.txt", true)) 
            {
                streamWriter.Write("aaaaaaaaaaaaaaaa");
            }
        }
    }
}
