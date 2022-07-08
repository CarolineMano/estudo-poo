using System;
using System.Collections.Generic;

namespace Exercicio03.Model
{
    public class Mago : Personagem
    {
        public List<string> Magias { get; set; }
        public Mago(string nome) : base(nome) 
        {
            this.Mana += 30;
            this.Inteligencia += 40;
            Magias = new List<string>();
        }
        public override void LvlUp()
        {
            base.LvlUp();
            this.Mana += 30;
            this.Inteligencia += 20;
        }
        public override int Attack()
        {
            int ataque = base.Attack() + this.Inteligencia * this.Level;
            Console.WriteLine($"\n{this.Nome} ataca, dando {ataque} pontos de dano!");
            return ataque;            
        }

        public void AprenderMagia(string magia)
        {
            Magias.Add(magia);
            Console.WriteLine($"\n{this.Nome} aprendeu a magia {magia}");
        }

        public void MostrarMagias()
        {
            Console.WriteLine($"\n-------Lista de Magias de {this.Nome}-------");
            for (int i = 0; i < Magias.Count; i++)
            {
                Console.WriteLine($"Magia {i+1}: {Magias[i]}");
            }
        }
    }
}