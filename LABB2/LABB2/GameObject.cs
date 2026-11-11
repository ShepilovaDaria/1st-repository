using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace LABB2
{
    public abstract class GameObject
    {
        private static int count = 1;
        private readonly int Id;
        private readonly string Name;
        protected int X { get; set; }
        protected int Y { get; set; }

        protected GameObject(string name, int x, int y)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Необходимо имя", nameof(name));

            Id = count++;
            Name = name;
            X = x;
            Y = y;
        }
        public int GetId() => Id;
        public string GetName() => Name;
        public int GetX() => X;
        public int GetY() => Y;

        public override string ToString() => 
            $"{GetType().Name}#{Id} \"{Name}\" ({X};{Y})";
    }

}

