using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_POO_RPG.Entities
{
    public abstract class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
        public Wizard()
        {

        }
        public override string Attack()
        {
            return Name + " Lançou uma magia";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return Name + " Lançou uma magia super efetiva com bonus de ataque de " + bonus;
            }
            else
            {
                return Name + " Lançou uma magia com força fraca com bonus de " + bonus;
            }
        }


    }
}
