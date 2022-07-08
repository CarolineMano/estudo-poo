using System;

namespace Exercicio07.Model
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; set; }
        public Funcionario(string nome, int idade, double salario, string cargo)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
            this.Cargo = cargo;
        }
        public virtual double Bonificacao()
        {
            return this.Salario;
        }

        public override string ToString()
        {
            return "\nNome: " + this.Nome + "\nCargo: " + this.Cargo + "\nIdade: " + 
                this.Idade + "\nSalário: R$" + String.Format("{0:0.00}", this.Salario) +
                "\nBonificação: R$" + String.Format("{0:0.00}", this.Bonificacao());
        }
    }
}