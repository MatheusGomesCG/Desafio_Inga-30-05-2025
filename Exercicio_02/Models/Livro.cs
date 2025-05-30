using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Exercicio_02.Models
{
    public class Livro
    {
        private static int id = 1;

        public int Id { get; private set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int QuantidadeEstoque { get; set; }

        public Livro() { }
        public Livro(string titulo, string autor, int quantidadeEstoque)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            QuantidadeEstoque = quantidadeEstoque;
            id++;
        }

        public void AdicionarEstoque(int quantidade)
        {
            QuantidadeEstoque += quantidade;
            Console.WriteLine("Estoque abastecido com sucesso!");
        }
        public void Vender(int quantidade)
        {
            if (QuantidadeEstoque >= quantidade) {
                QuantidadeEstoque -= quantidade;
                Console.WriteLine("Livro vendido com sucesso!");
            }
            else
                Console.WriteLine("Quantidade superior ao estoque");
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"ID = {Id}");
            sb.AppendLine($"Titulo = {Titulo}");
            sb.AppendLine($"Autor = {Autor}");
            sb.AppendLine($"Quantidade = {QuantidadeEstoque}");
            return sb.ToString();
        }


    }
}