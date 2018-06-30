using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troelsen2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Marvin",456,3000);
            emp.GiveBonus(1000);
            emp.DisplaySt();
            emp.SetName("Marvxdfbzdfbzdfbgfgzdfg");
            Console.WriteLine("name {0}", emp.GetName());
            Console.ReadLine();

            
        }
    }
}
