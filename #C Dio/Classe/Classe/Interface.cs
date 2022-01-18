namespace Interface
{
    interface IAnimal
    {
        void Nome(string nome);

        void Dono(string nomeDono);

        void Especie(string nomeEspecie);
    }

    class Animal : IAnimal
    {
        public string Nome { get; set; }

        public string NomeDono { get; set; }

        public string NomeEspecie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }


        void IAnimal.Dono(string nomeDono)
        {
            this.NomeDono = nomeDono;
        }

        void IAnimal.Especie(string nomeEspecie)
        {
            this.NomeEspecie = nomeEspecie;
        }


    }

}