using System;
using System.Globalization;
using Mentoria_GFT_POO.Entities;

namespace Mentoria_GFT_POO
{
    class program
    {
        static void Main(string[] args)
        {

            Imovel moradia = new Imovel("Recife", "Rua Francisco de Paula Machado n°123", 83, 4, 60.000);
            Apartamento moradia2 = new Apartamento("Recife--Pernanbuco", "Av GFT, 1000", 86, 7, 80.000, 9, "901", "B");

            System.Console.WriteLine(moradia);

            System.Console.WriteLine("-------------------");

            System.Console.WriteLine(moradia2);




        }


    }
}
