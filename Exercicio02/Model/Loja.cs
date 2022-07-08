using System;
using System.Collections.Generic;

namespace Exercicio02.Model
{
    public class Loja
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public List<Livro> Livros  { get; set; }
        public List<VideoGame> VideoGames { get; set; }
        public Loja(){}
        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            this.Nome = nome;
            this.Cnpj = cnpj;
            this.Livros = livros;
            this.VideoGames = videoGames;    
        }
        public void ListaLivros()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("A loja " + this.Nome + " possui estes livros para venda: ");
            if(this.Livros == null)
            {
                Console.WriteLine("A loja não tem livros no seu estoque");
                return;
            }
            foreach (var livro in Livros)
            {
                Console.WriteLine(livro);
            }
        }
        public void ListaVideoGames()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("A loja " + this.Nome + " possui estes video-games para venda: ");
            if(this.VideoGames == null)
            {
                Console.WriteLine("A loja não tem video-games no seu estoque");
                return;
            }
            foreach (var videogame in VideoGames)
            {
                Console.WriteLine(videogame);
            }
        }
        public double CalculaPatrimonio()
        {
            double patrimonio = 0;
            Console.WriteLine("---------------------------------------");
            if(this.Livros != null)
            {
                foreach (var livro in Livros)
                {
                    patrimonio += livro.Preco * livro.Qtd;
                }
            }
            if(this.VideoGames != null)
            {
                foreach (var videogame in VideoGames)
                {
                    patrimonio += videogame.Preco * videogame.Qtd;
                }
            }
            Console.WriteLine($"O patrimônio da loja {this.Nome} é de R$ {String.Format("{0:0.00}", patrimonio)}.");
            return patrimonio;
        }
    }
}