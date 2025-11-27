using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL13_Figurer
{
    public class Square : Rectangle
    {
        public override string Name => "Square";
        public Square(double side) : base(side, side)
        {

        }
    }
}
