using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    // 物理問題訪問者
    class PhysicsVisitor : Visitor
    {
        // 訪問誠實人的多載方法
        public override void visit(HonestManElement honestElement)
        {
            Console.WriteLine("{0} 說: 鐵球在水中會沉下去", honestElement.name);
        }

        // 訪問說謊人的多載方法
        public override void visit(LieManElement lieElement)
        {
            Console.WriteLine("{0} 說: 鐵球在水中會浮起來", lieElement.name);
        }
    }
}
