using System;
using System.Collections.Generic;
using System.Text;
using static LABB2.Interfaces;

namespace LABB2
{
    public class MobileHome : Building, Moveable
    {
        public MobileHome(string name, int x, int y, int buildtimeturns, bool built = false): base(name, x, y, buildtimeturns, built)
        {
        }

        public void MoveTo(int x, int y)
        {
            if (!IsBuilt()) return;  
            X += x;
            Y += y;
        }
    }
}

