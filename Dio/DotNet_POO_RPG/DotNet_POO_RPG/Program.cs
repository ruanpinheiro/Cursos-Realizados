using DotNet_POO_RPG.Entities;
using System;

namespace DotNet_POO_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus",23,"Knight");
            White_Wizard whiteWizard = new White_Wizard("Jennica", 23, "White Wizard");
            Ninja ninja = new Ninja("Wedge", 23, "Ninja");
            Black_Wizard blackWizard = new Black_Wizard("Topapa", 23, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(whiteWizard.Attack(1));
            Console.WriteLine(whiteWizard.Attack(7));
            Console.WriteLine(ninja.Attack(1));
            Console.WriteLine(blackWizard.Attack(11));

        }
    }
}
