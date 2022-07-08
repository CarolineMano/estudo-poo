using System;
using System.Collections.Generic;

namespace Exercicio03.Model
{
    public class Guerreiro : Personagem
    {
        public List<string> Habilidades { get; set; }
        public Guerreiro(string nome) : base(nome)
        {
            this.Forca += 30;
            this.Vida += 100;
            Habilidades = new List<string>();
        }
        public override void LvlUp()
        {
            base.LvlUp();
            this.Forca += 20;
            this.Vida += 100;
        }
        public override int Attack()
        {
            int ataque = base.Attack() + this.Forca * this.Level;
            Console.WriteLine($"\n{this.Nome} ataca, dando {ataque} pontos de dano!");
            return ataque;            
        }

        public void AprenderHabilidade(string habilidade)
        {
            Habilidades.Add(habilidade);
            Console.WriteLine($"\n{this.Nome} aprendeu a habilidade {habilidade}");
        }

        public void MostrarHabilidades()
        {   
            Console.WriteLine($"\n-------Lista de Habilidades de {this.Nome}-------");
            for (int i = 0; i < Habilidades.Count; i++)
            {
                Console.WriteLine($"Habilidade {i+1}: {Habilidades[i]}");
            }
        }
    }
}