using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troelsen2
{
    class Employee
    {
        private string empName;
        private int empID;
        private float currPay;

        public string GetName()
        {
            return empName;
        }
        public void SetName(string name)
        {
            if (name.Length > 15)
                Console.WriteLine("Error");
            else
                empName = name;

        }
        public Employee() { }
        public Employee(string name, int id, float pay)
        {
            empName = name;
            empID = id;
            currPay = pay;
        }
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public void DisplaySt()
        {
            Console.WriteLine("Name {0}", empName);
            Console.WriteLine("ID: {0}",empID);
            Console.WriteLine("Pay: {0}",currPay);
        }
    }

}
