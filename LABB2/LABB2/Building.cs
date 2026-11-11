using System;
using System.Collections.Generic;
using System.Text;

namespace LABB2
{
    public class Building : GameObject 
    {
        private bool b;
        private readonly int buildtime; 
        private int turns; 

        public Building(string name, int x, int y, int buildtimeturns, bool built = false): base(name, x, y)
        {
            buildtime = buildtimeturns;
            b = built;
            turns = built ? buildtimeturns : 0;
        }

        public bool IsBuilt() => b;
        public virtual void OnTurn()
        {
            if (b) return;

            turns++;
            if (turns >= buildtime)
                b = true;
        }

    }
}
