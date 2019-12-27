using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    // 物件結構
    class ObjectStructure
    {
        private List<Element> elements = new List<Element>();

        //增加元素物件
        public void Attach(Element element)
        {
            elements.Add(element);
        }

        //移除元素物件
        public void Detach(Element element)
        {
            elements.Remove(element);
        }

        //顯示
        public void Display(Visitor visitor)
        {
            foreach (Element e in elements)
            {
                e.Accept(visitor);
            }
        }
    }
}
