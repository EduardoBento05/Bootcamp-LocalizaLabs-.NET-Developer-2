using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
     public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void apresentar()
        {
            Console.WriteLine($"Olá Meu nome é {Nome}, tenho {Idade} anos  e sou um professor e Ganho {Salario}");
        }
    }
}
