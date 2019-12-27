using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    class Program
    {
        //備忘錄模式(Memento Pattern)

        //說明：
        //讓物件回復到之前狀態的方法。

        //實現重點在於，區分 Originator、Memento、Caretaker 三個物件
        //Originator 可將自己的狀態儲存在 Memento 中，
        //並將 Memento 保留在 Caretaker 裡面。
        //當 Originator 要回復狀態時，再從 Caretaker 取得 Memento 進行回復。
        static void Main(string[] args)
        {
            Player aa = new Player();
            Console.WriteLine("[初始狀態]");
            Console.WriteLine("HP : {0}", aa.hp);
            Console.WriteLine("EXP : {0}", aa.exp);

            Caretaker aaCaretaker = new Caretaker(); // 新增資料管理者
            aaCaretaker.PlayerMemento = aa.saveToMemento(); // 儲存目前狀態

            aa.run(-80, 125); // 戰鬥，HP、EXP 改變
            Console.WriteLine("{0}[戰鬥後]", Environment.NewLine);
            Console.WriteLine("HP : {0}", aa.hp);
            Console.WriteLine("EXP : {0}", aa.exp);

            aa.loadFromMemento(aaCaretaker.PlayerMemento); // 回復到戰鬥前的狀態
            Console.WriteLine("{0}[回復到戰鬥前]", Environment.NewLine);
            Console.WriteLine("HP : {0}", aa.hp);
            Console.WriteLine("EXP : {0}", aa.exp);


            Console.ReadLine();
        }
    }
}
