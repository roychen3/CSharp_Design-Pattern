using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    // 節點選單
    class CompositeMenu : MenuComponent
    {
        private List<MenuComponent> menu = new List<MenuComponent>();

        public CompositeMenu(string name)
            : base(name)
        {
        }

        // 新增
        public void Add(MenuComponent m)
        {
            menu.Add(m);
        }

        // 移除
        public void Remove(MenuComponent m)
        {
            menu.Remove(m);
        }

        public override void Print(int depth)
        {
            Console.WriteLine(new String('-', depth) + this.name);

            foreach (MenuComponent m in menu)
            {
                m.Print(depth + 1);
            }

        }
    }
}
