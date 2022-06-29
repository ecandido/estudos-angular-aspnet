namespace Project1
{
    public class Colaborador
    {
        public Colaborador()
        {

        }

        public Colaborador(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public string CorCabelo { get; set; } = "Loiro";
    }
}
