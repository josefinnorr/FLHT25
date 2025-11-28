using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL14_Eggfarm
{
    public class Egg
    {
       private static readonly Random _rnd = new();

        public int ID { get; }

        public bool IsFertile { get; private set; } = false;

        public override string ToString()
        {
            string result = "";
            

            if(!IsFertile)
            {
                result = "är inte fertilt";
            }
            return $"Ägg {ID} {result}";
        }

        public Chicken? Hatch()
        {
            if(IsFertile)
            {
                return new Chicken(ID);
            }
            return null; 
        }

        public Egg(int eggID)
        {
            ID = eggID;
            IsEggFertile();
        }

        private void IsEggFertile()
        {
            double prob = _rnd.NextDouble();
            if (prob < 0.9)
            {
                IsFertile = true;
            }
            else
            {
                IsFertile = false;
            }
        }
        public bool CureEgg()
        {
            IsEggFertile();
            return IsFertile;
        }
    }
}
