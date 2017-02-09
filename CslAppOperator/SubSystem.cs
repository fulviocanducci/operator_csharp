using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CslAppOperator
{
    public class SubSystem
    {
        public SubSystem()
        {

        }
        public SubSystem(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public static SubSystem operator +(SubSystem a, SubSystem b)
            => new SubSystem(a.X + b.X, a.Y + b.Y);

        public static SubSystem operator -(SubSystem a, SubSystem b)
            => new SubSystem(a.X - b.X, a.Y - b.Y);

        public static SubSystem operator /(SubSystem a, SubSystem b)
            => new SubSystem((a.X / b.X), (a.Y / b.Y));

        public static bool operator ==(SubSystem a, SubSystem b)
            => a.X == b.X && a.Y == b.Y;
        public static bool operator !=(SubSystem a, SubSystem b)
            => a.X != b.X || a.Y != b.Y;

        public static SubSystem operator *(SubSystem a, SubSystem b)
            => new SubSystem(a.X * b.X, a.Y * b.Y);

        public static explicit operator Key(SubSystem a)
            => new Key {  X = a.X, Y = a.Y};

        public static implicit operator bool(SubSystem a)
            => a.X > 0 && a.Y > 0;
        
        //Mesma coisa que implicit operator bool
        //public static bool operator true(SubSystem a)
        //    => a.X > 0 && a.Y > 0;
        //public static bool operator false(SubSystem a)
        //    => a.X <= 0 && a.Y <= 0;


    }

    public class Key
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
