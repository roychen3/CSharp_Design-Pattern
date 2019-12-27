using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    // 誠實人元素物件
    class HonestManElement : Element
    {
        public string name = "誠實人";
        public override void Accept(Visitor visitor)
        {
            // 將自己傳給訪問者，以便訪問者分辨、執行適合自己的行為
            visitor.visit(this);
        }
    }
}
