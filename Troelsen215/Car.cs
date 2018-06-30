using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troelsen215
{
    class Car
    {
        public string PetMame { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public void Disp()
        {
            Console.WriteLine("Car Name:{0}",PetMame);
            Console.WriteLine("Speed:{0}",Speed);
            Console.WriteLine("Color:{0}",Color);
        }
    }
}
