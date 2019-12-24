using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    //統一由指揮者 class 執行生產步驟
    class Director
    {
        private Bulider builder;

        public void setBulider(Bulider builder)
        {
            this.builder = builder;
        }

        public void create()
        {
            this.builder.TakeTheCup();
            this.builder.PourDrinks();
            this.builder.AddCover();
            this.builder.TakeAStraw();
        }
    }
}
