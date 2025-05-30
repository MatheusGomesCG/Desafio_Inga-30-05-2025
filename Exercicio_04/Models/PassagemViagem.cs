using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Exercicio_04.Models
{
    public class PassagemViagem
    {
        private static int id = 1;
        public string Id { get; set; }
        public string NomePassageiro { get; set; }
        public string Destino { get; set; }
        public decimal ValorBase { get; set; }
        public decimal TaxaEmbarque { get; set; }

        public PassagemViagem(string nomePassageiro, string destino, decimal valorBase, decimal taxaEmbarque)
        {
            Id = $"Voo-{id}";
            NomePassageiro = nomePassageiro;
            Destino = destino;
            ValorBase = valorBase;
            TaxaEmbarque = taxaEmbarque;
            id++;
        }

        public decimal ValorTotal()
        {
            return ValorBase + TaxaEmbarque;
        }

        public bool ValidarValores()
        {
            return ValorBase > 0 && TaxaEmbarque > 0;
        }

        public string ResumoPassagem()
        {
            StringBuilder sb = new();
            sb.AppendLine($"ID = {Id}");
            sb.AppendLine($"Nome = {NomePassageiro}");
            sb.AppendLine($"Destino = {Destino}");
            sb.AppendLine($"Valor total = {ValorTotal():C}");

            return sb.ToString();
        }
    }
}