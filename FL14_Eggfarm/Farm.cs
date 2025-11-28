using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL14_Eggfarm
{
    public class Farm
    {
        private List<Egg> _eggs = new();

        public Farm()
        {

        }

        public List<Egg> GetAllEggs()
        {
            return _eggs;
        }

        public Chicken? HatchEgg(Egg egg)
        {
            Chicken? chicken = egg.Hatch();
            _eggs.Remove(egg);
            return chicken;
        }

        public void BuyEggs(int count)
        {
            
            for(int i = 1; i <= count; i++)
            {
                Egg egg = new Egg(i);
                _eggs.Add(egg);
            }
        }

        public List<Egg> GetFertileEggs()
        {
            List<Egg> fertiles = new List<Egg>();

            foreach (Egg egg in _eggs)
            {
                if (egg.IsFertile)
                {
                    fertiles.Add(egg);
                }
            }
            return fertiles;

        }
    }
}
