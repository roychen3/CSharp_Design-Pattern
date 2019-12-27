using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    //通知者實做範例
    class ConcreteSubject : Subject
    {
        private string subjectState;

        //具體通知者狀態
        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }
}
