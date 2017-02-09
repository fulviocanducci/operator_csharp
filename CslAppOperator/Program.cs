using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CslAppOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operator
            SubSystem sub = new SubSystem(130, 50);
            if (sub)
            {
                System.Console.WriteLine("Passou !!!");
            }
            else
            {
                System.Console.WriteLine("Não Passou !!!");
            }
            Key key = (Key)sub;

            SubSystem sub2 = sub / new SubSystem(10,3) ;


            System.Console.ReadKey();
        }
    }
}
