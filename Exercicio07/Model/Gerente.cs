namespace Exercicio07.Model
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario, string cargo) : base(nome, idade, salario, cargo) {}


        public override double Bonificacao()
        {
            return base.Bonificacao() + 10000;
        }
    }
}