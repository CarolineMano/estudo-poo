using System;
using System.Collections.Generic;
using Exercicio04.Model;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>(); 
            int maxValue = 0;
            pessoas.Add(new Pessoa("João", 15));
            pessoas.Add(new Pessoa("Leandro", 21));
            pessoas.Add(new Pessoa("Paulo", 17));
            pessoas.Add(new Pessoa("Jessica", 18));

            foreach (Pessoa pessoa in pessoas)
            {
                maxValue = Math.Max(maxValue, pessoa.Idade);
            }
            foreach (Pessoa pessoa in pessoas)
            {
                if(pessoa.Idade == maxValue)
                {
                    Console.WriteLine("A pessoa mais velha é " + pessoa.Nome);
                    break;
                }                    
            }

            //Exercício 05
            List<Pessoa> pessoasAux = new List<Pessoa>(pessoas); 
            Console.WriteLine("\nQtde. de pessoas na lista: " + pessoas.Count);
            foreach (Pessoa pessoa in pessoasAux)
            {
                if(pessoa.Idade < 18)
                    pessoas.Remove(pessoa);    
            }
            Console.WriteLine("\nQtde. de pessoas na lista maiores de 18 anos: " + pessoas.Count);

            //Exercício 06
            foreach (Pessoa pessoa in pessoas)
            {
                if(pessoa.Nome == "Jessica")
                    Console.WriteLine("\nIdade de Jessica é: " + pessoa.Idade);
            }

        }
    }
}
