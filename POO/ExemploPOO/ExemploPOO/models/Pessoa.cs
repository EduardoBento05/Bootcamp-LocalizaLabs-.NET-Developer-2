using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Documento { get; set; }


        public virtual void apresentar()
        {
            Console.WriteLine($"Olá Meu nome é {Nome} e tenho {Idade} anos");
        }

       
    }
}
