using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_POO_RPG.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Hero(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public Hero()
        {


        }

        public override string ToString()
        {
           return Name + " " + Level + " " + HeroType;
        }

        public virtual string Attack()
        {
            return Name + " Atacou o oponente";
        }
    }
}
