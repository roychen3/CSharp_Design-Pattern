using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    //通知者的抽象類別
    abstract class Subject
    {
        private IList<Observer> observers = new List<Observer>();

        //增加觀察者
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }
        //刪除觀察者
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }
        //通知
        public void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }
    }
}
