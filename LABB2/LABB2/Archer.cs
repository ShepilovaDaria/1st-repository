using System;
using System.Collections.Generic;
using System.Text;
using static LABB2.Interfaces;

namespace LABB2
{
    public class Archer : Unit, Attacker, Moveable
    {
        private readonly float Damage;
        private readonly int MoveRange;
        public Archer(string name, int x, int y, float maxHp, float damage, int attackrange): base(name, x, y, maxHp)
        {
            Damage = damage;
            MoveRange = attackrange;
        }
        public void Attack(Unit unit)
        {
            if (unit is null)
                throw new System.ArgumentNullException(nameof(unit));

            if (!IsAlive()) return;
            if (!unit.IsAlive()) return;

            int dist = System.Math.Abs(GetX() - unit.GetX())
                     + System.Math.Abs(GetY() - unit.GetY());
            if (dist > MoveRange) return;

            unit.ReceiveDamage(Damage);
        }
        public void MoveTo(int x, int y)
        {
            if (!IsAlive()) return;   
            X += x;
            Y += y;
        }
    }
}
