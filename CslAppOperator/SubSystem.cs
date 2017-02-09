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

        //Faz a soma
        public static SubSystem operator +(SubSystem a, SubSystem b)
            => new SubSystem(a.X + b.X, a.Y + b.Y);

        //Faz a subtração 
        public static SubSystem operator -(SubSystem a, SubSystem b)
            => new SubSystem(a.X - b.X, a.Y - b.Y);

        //Faz a divisão e pega somente a parte de inteiros
        public static SubSystem operator /(SubSystem a, SubSystem b)
            => new SubSystem((a.X / b.X), (a.Y / b.Y));                 

        //Multiplica
        public static SubSystem operator *(SubSystem a, SubSystem b)
            => new SubSystem(a.X * b.X, a.Y * b.Y);

        //Convert para o outro tipo de forma explicita
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
