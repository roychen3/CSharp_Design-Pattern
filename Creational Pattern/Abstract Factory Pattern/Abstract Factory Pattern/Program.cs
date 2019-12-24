using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class Program
    {
        //抽象工廠模式(Abstract Factory Pattern)

        //說明：
        //抽象工廠類別，可返回同類型的工廠。這些返回的工廠，有多個相同的方法，做類似的事。

        //實現重點在於，利用抽像工廠類別，回傳實際生產的工廠物件。
        static void Main(string[] args)
        {
            AbstractFactory xx; // 抽像工廠
            ToyCar Car; // 製造玩具車的工廠
            ToyDog Dog; // 製造玩具狗的工廠

            // A 品牌
            xx = new Factory_A();
            Car = xx.CreateToyCar();
            Dog = xx.CreateToyDog();

            Car.MakeToyCar();
            Dog.MakeToyDog();

            Console.WriteLine("----------");

            // B 品牌
            xx = new Factory_B();
            Car = xx.CreateToyCar();
            Dog = xx.CreateToyDog();

            Car.MakeToyCar();
            Dog.MakeToyDog();

            Console.ReadLine();
        }
    }
}
