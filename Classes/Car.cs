using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        //Create a Make property of type string that is public
        public string Make { get; set; }

        //Create a Model property of type string that is public
        public string Model { get; set; }

        //Create a Year property of type int that is public
        public int Year { get; set; }

        public Car()
        {

        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }

    
}
