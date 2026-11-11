using System;
using System.Collections.Generic;
using System.Text;

namespace LABB2
{
    public class Interfaces
    {
        public interface Attacker
        {
            void Attack(Unit unit);
        }
        public interface Moveable
        {
            void MoveTo(int x, int y);
        }
    }

}
