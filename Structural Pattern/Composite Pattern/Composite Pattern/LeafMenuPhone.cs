using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    // 葉(手機)
    class LeafMenuPhone : MenuComponent
    {
        public LeafMenuPhone(string name)
            : base(name)
        {
        }

        public override void Print(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + "手機");
        }
    }
}
