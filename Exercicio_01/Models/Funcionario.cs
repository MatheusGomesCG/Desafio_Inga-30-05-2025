using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Exercicio_01.Models
{
    public class Funcionario
    {
        private static int id = 1;
        public int Id { get; private set; }
        public string Nome { get; set; }
        public decimal SalarioBase { get; set; }
        public string Cargo { get; set; }

        public Funcionario() { }
        public Funcionario(string nome, decimal salarioBase, string cargo)
        {
            Id = id;
            Nome = nome;
            SalarioBase = salarioBase;
            Cargo = cargo;
            id++;
        }
        public void CalcularBonus()
        {
            if (Cargo == "Gerente")
                SalarioBase *= 1.2M;
            else if (Cargo == "Analista")
                SalarioBase *= 1.1M;
            else
                SalarioBase *= 1.05M;

            Console.WriteLine($"O Salário de {Nome} foi atualizado para: {SalarioBase:C}");
        }
        public string SalarioTotal()
        {
            return $"{SalarioBase:C}";
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"ID = {Id}");
            sb.AppendLine($"Nome = {Nome}");
            sb.AppendLine($"Cargo = {Cargo}");
            sb.AppendLine($"Salario = {SalarioBase:C}");
            return sb.ToString();
        }

    }
}