using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_POO_RPG.Entities
{
    class Black_Wizard : Wizard
    {
        public Black_Wizard(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
        public Black_Wizard()
        {

        }

        public override string Attack()
        {
            return Name + " Lançou uma magia de escuridão";
        }

        public new string Attack(int bonusEscuridao)
        {
            if (bonusEscuridao > 6)
            {
                return Name + " Lançou uma magia de escuridão super efetiva com bonus de ataque de " + bonusEscuridao;
            }
            else
            {
                return Name + " Lançou uma magia de escurião com força fraca com bonus de " + bonusEscuridao;
            }
        }

    }

}

