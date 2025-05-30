using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_03.Models
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return $"Nome = {Nome}\nTelefone = {Telefone}";
        }
    }
}