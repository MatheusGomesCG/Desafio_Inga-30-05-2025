using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Exercicio_05.Models
{
    public class CartaoPrePago
    {
        public string NomeUsuario { get; set; }
        public decimal LimiteDisponivel { get; set; }

        public CartaoPrePago(string nomeUsuario, decimal limiteDisponivel)
        {
            NomeUsuario = nomeUsuario;
            LimiteDisponivel = limiteDisponivel;
        }
        public void AdicionarCredito(decimal valor)
        {
            if (valor > 0)
            {
                LimiteDisponivel += valor;
                Console.WriteLine("Limite foi acrescentado com sucesso!!");
            }
            else
                Console.WriteLine("Valor informado é inválido");
        }
        public void RealizarCompra(decimal valor)
        {
            if (LimiteDisponivel >= valor)
            {
                LimiteDisponivel -= valor;
                Console.WriteLine("Compra realizada com sucesso!!!!");
            }
            else
                Console.WriteLine("Limite da compra superior ao permitido");
        }

        public string ExibirResumo()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Nome = {NomeUsuario}");
            sb.AppendLine($"Limite = {LimiteDisponivel:C}");

            return sb.ToString();
        }
    }
}