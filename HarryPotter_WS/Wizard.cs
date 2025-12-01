using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter_WS
{
    public class Wizard
    {
        public string Name { get; set; }
        public bool HasWand { get; set; }
        public Wand? Wand { get; set; } // Den här propertyn kan vara null = trollkarl waknar stav
    }

}
