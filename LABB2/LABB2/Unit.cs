using System;
using System.Collections.Generic;
using System.Text;

namespace LABB2
{
    public abstract class Unit : GameObject
    {
        private float Hp;
        private readonly float maxHp;
        public Unit(string name, int x, int y, float mxHp): base(name, x, y) 
        {
            if (mxHp <= 0)
                throw new ArgumentOutOfRangeException(nameof(mxHp), "Максимальное HP > 0");

            maxHp = mxHp;
            Hp = maxHp;
        }
        public bool IsAlive() => Hp > 0;
        public float GetHp() => Hp;
        public string LifeStatus()
        {
            if (IsAlive()) return "alive";
            else return "dead";
        }
        public virtual void ReceiveDamage(float damage)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage), "Урон > 0");

            if (!IsAlive()) return;  
            Hp -= damage;
            if (Hp < 0) Hp = 0;
        }


    }
}
