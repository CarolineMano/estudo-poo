namespace Exercicio07.Model
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario, string cargo) : base(nome, idade, salario, cargo){}
        public override double Bonificacao()
        {
            return base.Bonificacao() + 3000;
        }
    }
}