using System;

namespace Exercicio01.Model
{
    public class Veiculo 
    {
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private string Placa { get; set; }
        private string Cor { get; set; }
        private float Km { get; set; }
        private bool IsLigado { get; set; }
        private int LitrosCombustivel { get; set; }
        private int Velocidade { get; set; }
        private double Preco { get; set; }

        public Veiculo(string marca, string modelo, string placa, string cor, float km, bool isLigado, int litrosCombustivel, int velocidade, double preco)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Placa = placa;
            this.Cor = cor;
            this.Km = km;
            this.IsLigado = isLigado;
            this.LitrosCombustivel = litrosCombustivel;
            this.Velocidade = velocidade;
            this.Preco = preco;
        }
        public void Acelerar()
        {
            this.Velocidade += 20;
        }
        public void Abastecer(int combustivel)
        {
            if(LitrosCombustivel + combustivel <= 60)
                this.LitrosCombustivel += combustivel;
            else
                Console.WriteLine($"Tanque irá transbordar. Abasteça com até {60 - this.LitrosCombustivel}");
        }
        public void Frear()
        {
            this.Velocidade -= 20;
        }
        public void Pintar(String cor)
        {
            this.Cor = cor;
        }
        public void Ligar()
        {
            if(!this.IsLigado)
                this.IsLigado = true;
        }
        public void Desligar()
        {
            if(this.IsLigado)
                this.IsLigado = false;
        }

        public override string ToString()
        {
            string saida = "\nMarca: " + this.Marca + "\nModelo: " +
                this.Modelo + "\nPlaca: " + this.Placa + "\nCor: " +
                this.Cor + "\nKM: " + this.Km + "\nEstá ligado? " +
                this.IsLigado + "\nLitros de Combustível: " + 
                this.LitrosCombustivel+ "\nVelocidade: " + 
                this.Velocidade + "\nPreço: R$" + String.Format("{0:0.00}", this.Preco);
            return saida;
        }
    }
}