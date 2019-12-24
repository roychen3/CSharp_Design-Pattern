using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{    
    class Program
    {
        //組合模式 (Composite Pattern)

        //說明：
        //數個物件之間，呈現一種樹狀結構。物件之間可以組合。

        //實現重點在於，節點能夠連接另一個節點或葉。
        static void Main(string[] args)
        {
            CompositeMenu cm = new CompositeMenu("分類");

            CompositeMenu cm_A = new CompositeMenu("A品牌");
            cm_A.Add(new LeafMenuPhone("Android"));
            cm_A.Add(new LeafMenuNB("14吋"));
            cm_A.Add(new LeafMenuNB("15吋"));
            cm.Add(cm_A);

            CompositeMenu cm_B = new CompositeMenu("B品牌");
            cm_B.Add(new LeafMenuPhone("Android"));
            cm_B.Add(new LeafMenuNB("13吋"));
            cm_B.Add(new LeafMenuNB("14吋"));
            cm.Add(cm_B);

            CompositeMenu cm_sale = new CompositeMenu("特價區");
            CompositeMenu cm_A2 = new CompositeMenu("A品牌");
            LeafMenuNB leaf_nb_14 = new LeafMenuNB("超值14吋");
            LeafMenuNB leaf_nb_15 = new LeafMenuNB("超值15吋");
            cm_A2.Add(leaf_nb_14); // 新增超值14吋
            cm_A2.Add(leaf_nb_15); // 新增超值15吋
            cm_A2.Remove(leaf_nb_15); // 移除超值15吋
            cm_sale.Add(cm_A2);
            cm.Add(cm_sale);

            cm.Print(0);

            Console.Read();
        }
    }
}
