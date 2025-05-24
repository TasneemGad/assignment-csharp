using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_1
{
    internal class Car
    {
        public int  Make { get; set; }
        public int Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public int Age { get { return DateTime.Now.Year - Year; } }


        public void Drive(int distance)
        {
            Mileage = Mileage + distance;
        }
    }
}
