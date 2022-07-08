namespace Exercicio07.Model
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario, string cargo) : base(nome, idade, salario, cargo) {}
        public override double Bonificacao()
        {
            return base.Bonificacao() + 5000;
        }
    }
}