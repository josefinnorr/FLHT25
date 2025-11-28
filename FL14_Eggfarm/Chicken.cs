using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL14_Eggfarm
{
   public class Chicken
    {
        public string Name { get; set; } = "Agda";
        public int ID { get; }
        public Chicken(int id)
        {
            ID = id;
        }
    }
}
