using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troelsen
{
    class Car
    {
        public string petName;
        public int cSpeed;
        private Radio MyRadio = new Radio();
        public void Turn(bool onOff)
        {
            MyRadio.Power(onOff);
        }
        public Car()
        {
           petName = "Volvo";
           cSpeed = 30;
        }
        public void PrintSpeed()  
        {
            Console.WriteLine("Название : {0}  Км/ч  {1} ", petName,cSpeed);
        }
        public void SpeedUp(int delta)
        {
            cSpeed += delta;
        }
    }
}
