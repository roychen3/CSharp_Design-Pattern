using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    // 訪問者 (能根據不同元素，產生不同結果)
    abstract class Visitor
    {
        // 訪問誠實人的多載方法
        public abstract void visit(HonestManElement honestElement);

        // 訪問說謊人的多載方法
        public abstract void visit(LieManElement lieElement);
    }
}
