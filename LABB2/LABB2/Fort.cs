using System;
using System.Collections.Generic;
using System.Text;
using static LABB2.Interfaces;

namespace LABB2
{
    public class Fort : Building, Attacker
    {
        private readonly float Damage;
        private readonly int attackR;
        public Fort(string name, int x, int y, int buildtimeturns, float damage, int attackrange, bool built = false): base(name, x, y, buildtimeturns, built)
        {
            Damage = damage;
            attackR = attackrange;
        }
        public void Attack(Unit unit)
        {
            if (unit is null)
                throw new ArgumentNullException(nameof(unit));

            if (!IsBuilt()) return;      
            if (!unit.IsAlive()) return;

            int dist = Math.Abs(GetX() - unit.GetX())
                     + Math.Abs(GetY() - unit.GetY());
            if (dist > attackR) return;

            unit.ReceiveDamage(Damage);
        }
    }
}
