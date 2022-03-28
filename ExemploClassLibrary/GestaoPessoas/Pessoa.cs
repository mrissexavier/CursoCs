namespace GestaoPessoas
{
    public class Pessoa
    {
        string nome;

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public string Nome { get => nome; set => nome = value; }
    }
}