using System;
using System.Collections.Generic;
using System.Text;

namespace CircleLab
{
    class Circle
    {
        //Properties
        private double radius;

        //Constructor
        public Circle(double r)
        {
            radius = r;
        }

        //Methods
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        private string FormatNumber(double x)
        {
            return string.Format("{0:0.00}", x);
        }

        public string CalculateFormattedCircumference()
        {
            double result = CalculateCircumference();
            return FormatNumber(result); 
        }

        public string CalculateFormattedArea()
        {
            double result = CalculateArea();
            return FormatNumber(result);
        }
    }
}
