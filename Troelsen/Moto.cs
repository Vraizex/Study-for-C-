using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troelsen
{
    class Moto : Car
    {
        public int madeYear;
        public Moto()
        {
            petName = "Yamaha";
            madeYear = 1970;
            cSpeed = 10;
        }
        public void Print()
        {
            Console.WriteLine("Название {0} Год выпуска {1}   Скорость {2}", petName, madeYear, cSpeed);
        }
    }
}
