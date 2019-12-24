using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    interface Bulider
    {
        void TakeTheCup();

        void PourDrinks();

        void AddCover();

        void TakeAStraw();
    }
}
