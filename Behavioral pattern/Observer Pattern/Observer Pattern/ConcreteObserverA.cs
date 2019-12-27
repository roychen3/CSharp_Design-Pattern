using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    //第一種觀察者實做範例
    class ConcreteObserverA : Observer
    {
        private string name;
        private ConcreteSubject subject;
        public ConcreteObserverA(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            Console.WriteLine("{0}事件，{1} 說：酸酸酸~~",
              this.subject.SubjectState, name);
        }
    }
}
