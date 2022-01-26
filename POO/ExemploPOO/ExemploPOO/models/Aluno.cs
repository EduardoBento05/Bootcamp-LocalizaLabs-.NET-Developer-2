using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExemploPOO.models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void apresentar()
        {
            Console.WriteLine($"Olá Meu nome é {Nome}, tenho {Idade} anos  e sou um aluno de nota {Nota}");
        }
    }
}
