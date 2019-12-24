using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    class Program
    {
        //單例模式(Singleton Pattern)

        //說明：
        //讓一個類別只能有一個實例(Instance)的方法。
        //產生單一實例的方式：
        //懶漢方式(Lazy initialization)：第一次使用時，才產生實例。
        //餓漢方式(Eager initialization)：class 載入時就產生實例，不管後面會不會用到。

        //實現重點在於，確保 class 回傳的實例，都是同一個，有以下兩種做法。
        static void Main(string[] args)
        {
            Console.WriteLine("懶漢方式");
            // 產生第一個實例
            SingletonLazy a = SingletonLazy.GetInstance();
            Console.WriteLine("a.test = {0}", a.test); // a.test = 1
            a.test = 10; // 將第一個實例的 test 值，改為 10
            Console.WriteLine("a.test = {0}", a.test); // a.test = 10

            // 產生第二個實例
            SingletonLazy b = SingletonLazy.GetInstance();
            Console.WriteLine("b.test = {0}", b.test); // b.test = 10

            Console.WriteLine(b == a); // True, b 跟 a 是同一個實例 

            Console.WriteLine("\n------------\n");

            Console.WriteLine("餓漢方式");
            // 產生第一個實例
            SingletonEager c = SingletonEager.GetInstance();
            Console.WriteLine("c.test = {0}", c.test); // c.test = 1
            c.test = 10; // 將第一個實例的 test 值，改為 10
            Console.WriteLine("c.test = {0}", c.test); // c.test = 10

            // 產生第二個實例
            SingletonEager d = SingletonEager.GetInstance();
            Console.WriteLine("d.test = {0}", d.test); // d.test = 10

            Console.WriteLine(d == c); // True, d 跟 c 是同一個實例 

            Console.Read();
        }
    }
}
