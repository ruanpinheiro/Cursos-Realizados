using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_POO_RPG.Entities
{
    class White_Wizard : Wizard
    {
        public White_Wizard(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
        public White_Wizard()
        {

        }

        public override string Attack()
        {
            return Name + " Lançou uma magia de luz";
        }

        public new string Attack(int bonusDeLuz)
        {
            if (bonusDeLuz > 6)
            {
                return Name + " Lançou uma magia de luz super efetiva com bonus de ataque de " + bonusDeLuz;
            }
            else
            {
                return Name + " Lançou uma magia de luz com força fraca com bonus de " + bonusDeLuz;
            }
        }

    }
}
