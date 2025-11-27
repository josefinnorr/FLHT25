using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL13_Figurer
{
    public class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public override string Name => "Triangle";

        public Triangle(double baselength, double height)
        {

        }

        // Detta är ett exempel på polymorfism/flerformighet
        public override double GetArea()
        {
            return BaseLength * Height * 0.5;
        }
    }

}
