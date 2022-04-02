using System;
using AbstraindoUmjogoDeRPG.src.Entities;

namespace AbstraindoUmjogoDeRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight heroi = new Knight("Arus",25,"Heroi");
            Wizard whizard = new Wizard ("Mago",28,"Wizard");

            System.Console.WriteLine(heroi.Attack());
            System.Console.WriteLine(whizard.Attack(8));

        }
    }
}
