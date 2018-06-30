using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troelsen
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Moto myMot = new Moto();
            myCar.Turn(true);
            for (int i = 0; i <= 5; i++)
            {     
                myCar.SpeedUp(10);
                myCar.PrintSpeed();
                myMot.Print();
                myMot.SpeedUp(10);
            }  
            Console.ReadKey();
        }
    }
}
