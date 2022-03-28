using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public Pessoa()
        {
            Nome = "";
            Cidade = "";
            Idade = 0;
            Email = "";
        }

        public Pessoa(string nome, string cidade, int idade, string email)
        {
            this.Nome = nome;
            this.Cidade = cidade;
            this.Idade = idade;
            this.Email = email;
        }

        public Pessoa(Pessoa pessoa)
        {
            Nome = pessoa.Nome;
           Cidade = pessoa.Cidade;
           Idade = pessoa.Idade;
           Email = pessoa.Email;
        }

        public override string? ToString()
        {
            return ($"Nome: {Nome}" +
                $"\nCidade: {Cidade}" +
                $"\nIdade: {Idade}" +
                $"\nEmail: {Email}\n");
        }

        public override bool Equals(object? obj)
        {
            if (Nome == ((Pessoa)obj).Nome &&
                Cidade == ((Pessoa)obj).Cidade &&
                 Idade == ((Pessoa)obj).Idade &&
                Email == ((Pessoa)obj).Email);
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
