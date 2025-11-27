using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL13_Figurer
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override string Name => "Rectangle";

        public Rectangle (double width, double height)
        {

        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
