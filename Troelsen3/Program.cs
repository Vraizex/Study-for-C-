using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troelsen3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MOVE SOFTWARE");
            Employee emp = new Employee("NAMREEE", 460,300000);
            Employee joy = new Employee();
            joy.Age++;
            emp.GiveBonus(1000);
            emp.DisplaySt();
            emp.Name = "Pepe";
            Console.WriteLine("sdgasdg {0}",emp.Name);
            
            Console.ReadLine();
        }
    }
}
