using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Circle
    {
        //properties
        public double radius;
        //constructor
        public Circle(double newRadius)
        { SetRadius(newRadius); }
        //methods
        public void SetRadius(double newRadius)
        {
            if (newRadius > 0)
            { 
                radius = newRadius; //set radius if great than 0
            }
            else
            { 
                throw new InvalidRadiusException("Radius must be greater than zero!"); //throw to exception class
            }
        }

        public override string ToString()
        { return $"Circle radius = {radius}"; }
    }
}
