using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troelsen215
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Staaarted program");
            Car c = new Car();
            c.PetMame = "Fread";
            c.Speed = 55;
            c.Color = "Red";
            c.Disp();
            Garage g = new Garage();
            g.MyAuto = c;
            Console.WriteLine("Number car:{0}", g.NumberOfCars);
            Console.WriteLine("Имя:{0}",g.MyAuto.PetMame);
       
            Console.ReadLine();
        }
    }
}
