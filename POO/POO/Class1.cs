using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Pessoa
    {
        string nome;
        string cidade;
        int idade;
        string email;

        public Pessoa()
        {
            nome = "";
            cidade = "";
            idade = 0;
            email = "";
        }

        public Pessoa(string nome, string cidade, int idade, string email)
        {
            this.nome = nome;
            this.cidade = cidade;
            this.idade = idade;
            this.email = email;
        }

        public override string? ToString()
        {
            return ($"Nome: {nome}" +
                $"\nCidadae: {cidade}" +
                $"\nIdade: {idade}" +
                $"\nEmail: {email}\n");
        }
    }
}
