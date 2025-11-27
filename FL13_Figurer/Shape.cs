using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL13_Figurer
{
    public abstract class Shape
    {
        public abstract string Name { get; }

        public abstract double GetArea();
    }
}
