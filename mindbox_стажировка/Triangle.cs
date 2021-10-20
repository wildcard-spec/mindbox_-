using System;
using System.Collections.Generic;
using System.Text;

namespace mindbox_стажировка
{
    public class Triangle : Shape
    {
        private bool _isRight = false;
        public bool IsRight
        {
            get => _isRight;
            set => _isRight = value;
        }
        public Triangle(double a, double b, double c)
        {
            if (Math.Pow(c, 2) == (Math.Pow(a, 2) + Math.Pow(b, 2)))
            {
                this.IsRight = true;
            }




            double p = (a + b + c) / 2;
            this.Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));


        }
    }
}
