using System;
using System.Collections.Generic;
using System.Text;

namespace mindbox_стажировка
{
    public class Circle : Shape
    {
        private double Pi = 3.14;

        public Circle(double radius)
        {
            
                this.Area = 2 * Pi * radius;
            

        }


    
    }
}
