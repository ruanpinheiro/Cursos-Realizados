using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_POO_RPG.Entities
{
    class Knight : Hero
    {
        public Knight(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
    }
}
