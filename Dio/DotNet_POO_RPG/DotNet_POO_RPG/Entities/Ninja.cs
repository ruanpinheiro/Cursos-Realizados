using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_POO_RPG.Entities
{
    class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
        public override string Attack()
        {
            return Name + " Atacou com sua adaga envenenada";
        }
        public string Attack(int sangramento)
        {
            return Name + " Atacou com sua adaga envenenada causando sangramento de " + sangramento;
        }

    }
}
