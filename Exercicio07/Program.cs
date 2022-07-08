﻿using System;
using Exercicio07.Model;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente("Andre", 38, 9000.50, "Gerente");
            Supervisor supervisor = new Supervisor("Paulo", 33, 6020.0, "Supervisor");
            Vendedor vendedor = new Vendedor("Sidney", 28, 2130.40, "Vendedor");

            Console.WriteLine(gerente);
            Console.WriteLine(supervisor);
            Console.WriteLine(vendedor);
        }
    }
}
