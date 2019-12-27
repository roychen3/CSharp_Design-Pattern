using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    // 資料管理者
    class Caretaker
    {
        private Memento _PlayerMemento;

        public Memento PlayerMemento
        {
            get { return _PlayerMemento; }
            set { _PlayerMemento = value; }
        }
    }
}
