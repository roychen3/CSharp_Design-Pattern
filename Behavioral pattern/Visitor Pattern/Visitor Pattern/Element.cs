using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    // 元素抽像類別 (要放入物件結構中) 
    abstract class Element
    {
        // 每個元素要能接收訪問者物件，以便再將自己傳給訪問者
        public abstract void Accept(Visitor visitor);
    }    
}
