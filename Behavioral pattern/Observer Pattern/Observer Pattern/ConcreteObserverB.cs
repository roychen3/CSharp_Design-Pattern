using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    //第二種觀察者實做範例
    class ConcreteObserverB : Observer
    {
        private string name;
        private ConcreteSubject subject;
        public ConcreteObserverB(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            Console.WriteLine("{0}事件，{1} 說：讚讚讚~~",
              this.subject.SubjectState, name);
        }
    }
}
