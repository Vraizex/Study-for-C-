using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troelsen3
{
        class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error");
                else
                    empName = value;
            }
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }

        }
        //public string SocSectNumber
        //{
        //    get { return empSSN; }
        //}
        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay) { }

        public Employee(string name,int age, int id, float pay)
        {
            empName = name;
            empID = id;
            empAge = age;
            currPay = pay;
        }
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public void DisplaySt()
        {
            Console.WriteLine("Name {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Age: {0}", empAge);
            Console.WriteLine("Pay: {0}", currPay);
        }
    }

}
