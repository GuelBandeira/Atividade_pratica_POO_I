using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Tarefas.src
{
    public class Usuario
    {
        public string Cpf { get; private set; }
        public string Nome { get; private set; }
        public string Cargo { get; private set; }

        public Usuario(string nome, string cpf, string cargo)
        {
            Nome = nome;
            Cpf = cpf;
            Cargo = cargo;
        }
    }
}
