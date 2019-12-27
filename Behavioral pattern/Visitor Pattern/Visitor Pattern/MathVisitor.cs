using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    // 數學問題訪問者
    class MathVisitor : Visitor
    {
        // 訪問誠實人的多載方法
        public override void visit(HonestManElement honestElement)
        {
            Console.WriteLine("{0} 說: 1+1=2", honestElement.name);
        }

        // 訪問說謊人的多載方法
        public override void visit(LieManElement lieElement)
        {
            Console.WriteLine("{0} 說: 1+1=3", lieElement.name);
        }
    }
}
